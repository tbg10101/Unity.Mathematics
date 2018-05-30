using System.Runtime.CompilerServices;

namespace Unity.Mathematics {
    public static partial class math_x {
        // radians (convert from degrees to radians)
        [MethodImpl((MethodImplOptions) 0x100)]
        public static double radians (double degrees) {
            return degrees * 0.0174532925;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double2 radians (double2 degrees) {
            return degrees * 0.0174532925;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double3 radians (double3 degrees) {
            return degrees * 0.0174532925;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double4 radians (double4 degrees) {
            return degrees * 0.0174532925;
        }

        // radians (convert from radians to degrees)
        [MethodImpl((MethodImplOptions) 0x100)]
        public static double degrees (double radians) {
            return radians * 57.295779513;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double2 degrees (double2 radians) {
            return radians * 57.295779513;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double3 degrees (double3 radians) {
            return radians * 57.295779513;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double4 degrees (double4 radians) {
            return radians * 57.295779513;
        }


        // cmin - returns the smallest component of the vector
        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmin (double a) {
            return a;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmin (double2 a) {
            return min(a.x, a.y);
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmin (double3 a) {
            return min(min(a.x, a.y), a.z);
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmin (double4 a) {
            return min(min(min(a.x, a.y), a.z), a.w);
        }

        // cmax - returns the largest component of the vector
        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmax (double a) {
            return a;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmax (double2 a) {
            return max(a.x, a.y);
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmax (double3 a) {
            return max(max(a.x, a.y), a.z);
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double cmax (double4 a) {
            return max(max(max(a.x, a.y), a.z), a.w);
        }

        // csum - sums all components of the vector
        [MethodImpl((MethodImplOptions) 0x100)]
        public static double csum (double a) {
            return a;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double csum (double2 a) {
            return a.x + a.y;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double csum (double3 a) {
            return a.x + a.y + a.z;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double csum (double4 a) {
            return a.x + a.y + a.z + a.w;
        }

        // A numeric optimization fence.
        // prevents the compiler from optimizing operators.
        // Some algorithms are written in specific ways to get more precision.
        // For example: https://en.wikipedia.org/wiki/Kahan_summation_algorithm
        // this gives the programmer a tool to prevent specific optimization.
        // example:
        // var c = math.nfence(a + b) * c;
        [MethodImpl((MethodImplOptions) 0x100)]
        public static double nfence (double value) {
            return value;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double2 nfence (double2 value) {
            return value;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double3 nfence (double3 value) {
            return value;
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double4 nfence (double4 value) {
            return value;
        }

        // fract
        [MethodImpl((MethodImplOptions) 0x100)]
        public static double fract (double a) {
            return a - floor(a);
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double2 fract (double2 a) {
            return a - floor(a);
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double3 fract (double3 a) {
            return a - floor(a);
        }

        [MethodImpl((MethodImplOptions) 0x100)]
        public static double4 fract (double4 a) {
            return a - floor(a);
        }

#if false

//@TODO: Complete all versions of this also, this implementation doesn't actaully do  msb(y) ? -x : x...

//  changesign: change sign
//  return value: msb(y) ? -x : x
        public static double4 chgsign(double4 val, double sign) { return new double4(chgsign(val.x, sign), chgsign(val.y, sign), chgsign(val.z, sign), chgsign(val.w, sign)); }
        public static double4 chgsign(double4 val, double4 sign) { return new double4(chgsign(val.x, sign.x), chgsign(val.y, sign.y), chgsign(val.z, sign.z), chgsign(val.w, sign.w)); }
        public static double chgsign(double val, double sign) { return sign >= 0.0F ? val : -val; }

        //  sign: change sign
        //  return value: Returns -1 if x is less than zero; 0 if x equals zero; and 1 if x is greater than zero.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool msb(double val) { return (IntFloatUnion.ToInt(val) & 0x80000000) != 0; }

        //  copysign: copys the sign bit from sign to val
        //  return value: msb(sign) ? abs(val) : -abs(val)
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 copysign(double4 val, double sign)  { return sign < 0.0F ? -val : val; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double4 copysign(double4 val, double4 sign) { return new double4(sign.x < 0.0F ? -val.x : val.x, sign.y < 0.0F ? -val.y : val.y, sign.z < 0.0F ? -val.z : val.z, sign.w < 0.0F ? -val.w : val.w); }

#endif
    }
}
