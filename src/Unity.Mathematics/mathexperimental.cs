namespace Unity.Mathematics.Experimental
{
    public static partial class math_experimental
    {
        //@TODO hack
        static float4 epsilon4f { get { return new float4(0.00001f); } }
        static float3 epsilon3f { get { return new float3(0.00001f); } }
        static float2 epsilon2f { get { return new float2(0.00001f); } }
        static double4 epsilon4d { get { return new double4(0.00001); } }
        static double3 epsilon3d { get { return new double3(0.00001); } }
        static double2 epsilon2d { get { return new double2(0.00001); } }

        public const float epsilon = 0.00001f;

        //@TODO: Test len > epsilon4f... it is weird. compare to hlsl beahviour...
        // discuss if we want this function at all???
        static public float4 normalizeSafe(float4 v, float4 defaultValue = new float4())
        {
            float len = math.dot(v, v);
            return math.select(defaultValue, v * math.rsqrt(len), len > epsilon4f);
        }
        //@TODO: Test len > epsilon4d... it is weird. compare to hlsl beahviour...
        // discuss if we want this function at all???
        static public double4 normalizeSafe(double4 v, double4 defaultValue = new double4())
        {
            double len = math.dot(v, v);
            return math.select_d(defaultValue, v * math.rsqrt(len), len > epsilon4d);
        }

        //@TODO: Merge back into one function with default values... Causes compiler error right now...
        static public float3 normalizeSafe(float3 v, float3 defaultValue)
        {
            float len = math.dot(v, v);
            return math.select(defaultValue, v * math.rsqrt(len), len > epsilon3f);
        }
        static public float3 normalizeSafe(float3 v)
        {
            float len = math.dot(v, v);
            return math.select(new float3(), v * math.rsqrt(len), len > epsilon3f);
        }

        static public float2 normalizeSafe(float2 v, float2 defaultValue = new float2())
        {
            float len = math.dot(v, v);
            return math.select(defaultValue, v * math.rsqrt(len), len > epsilon2f);
        }

        //@TODO: Merge back into one function with default values... Causes compiler error right now...
        static public double3 normalizeSafe(double3 v, double3 defaultValue)
        {
            double len = math.dot(v, v);
            return math.select_d(defaultValue, v * math.rsqrt(len), len > epsilon3d);
        }
        static public double3 normalizeSafe(double3 v)
        {
            double len = math.dot(v, v);
            return math.select_d(new double3(), v * math.rsqrt(len), len > epsilon3d);
        }

        static public double2 normalizeSafe(double2 v, double2 defaultValue = new double2())
        {
            double len = math.dot(v, v);
            return math.select_d(defaultValue, v * math.rsqrt(len), len > epsilon2d);
        }
    }
}
