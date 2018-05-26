namespace Unity.Mathematics.Experimental {
    public static class math_experimental_x {
        //@TODO hack
        static float4 epsilon4f => new float4(0.00001f);

        static float3 epsilon3f => new float3(0.00001f);

        static float2 epsilon2f => new float2(0.00001f);

        static double4 epsilon4d => new double4(0.00001);

        static double3 epsilon3d => new double3(0.00001);

        static double2 epsilon2d => new double2(0.00001);

        public const float epsilon = 0.00001f;

        //@TODO: Test len > epsilon4d... it is weird. compare to hlsl beahviour...
        // discuss if we want this function at all???
        static public double4 normalizeSafe (double4 v, double4 defaultValue = new double4()) {
            double len = math_x.dot(v, v);
            return math_x.@select(defaultValue, v * math_x.rsqrt(len), len > epsilon4d);
        }

        //@TODO: Merge back into one function with default values... Causes compiler error right now...
        static public double3 normalizeSafe (double3 v, double3 defaultValue) {
            double len = math_x.dot(v, v);
            return math_x.@select(defaultValue, v * math_x.rsqrt(len), len > epsilon3d);
        }

        static public double3 normalizeSafe (double3 v) {
            double len = math_x.dot(v, v);
            return math_x.@select(new double3(), v * math_x.rsqrt(len), len > epsilon3d);
        }

        static public double2 normalizeSafe (double2 v, double2 defaultValue = new double2()) {
            double len = math_x.dot(v, v);
            return math_x.@select(defaultValue, v * math_x.rsqrt(len), len > epsilon2d);
        }
    }
}