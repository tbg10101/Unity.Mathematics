// GENERATED CODE

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661
namespace Unity.Mathematics {
    public partial struct double2 : IEquatable<double2> {
        // mul
        [MethodImpl(0x100)]
        public static double2 operator * (double2 lhs, double2 rhs) {
            return new double2(lhs.x * rhs.x, lhs.y * rhs.y);
        }

        [MethodImpl(0x100)]
        public static double2 operator * (double2 lhs, double rhs) {
            return new double2(lhs.x * rhs, lhs.y * rhs);
        }

        [MethodImpl(0x100)]
        public static double2 operator * (double lhs, double2 rhs) {
            return new double2(lhs * rhs.x, lhs * rhs.y);
        }

        // add
        [MethodImpl(0x100)]
        public static double2 operator + (double2 lhs, double2 rhs) {
            return new double2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        [MethodImpl(0x100)]
        public static double2 operator + (double2 lhs, double rhs) {
            return new double2(lhs.x + rhs, lhs.y + rhs);
        }

        [MethodImpl(0x100)]
        public static double2 operator + (double lhs, double2 rhs) {
            return new double2(lhs + rhs.x, lhs + rhs.y);
        }

        // sub
        [MethodImpl(0x100)]
        public static double2 operator - (double2 lhs, double2 rhs) {
            return new double2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        [MethodImpl(0x100)]
        public static double2 operator - (double2 lhs, double rhs) {
            return new double2(lhs.x - rhs, lhs.y - rhs);
        }

        [MethodImpl(0x100)]
        public static double2 operator - (double lhs, double2 rhs) {
            return new double2(lhs - rhs.x, lhs - rhs.y);
        }

        // div
        [MethodImpl(0x100)]
        public static double2 operator / (double2 lhs, double2 rhs) {
            return new double2(lhs.x / rhs.x, lhs.y / rhs.y);
        }

        [MethodImpl(0x100)]
        public static double2 operator / (double2 lhs, double rhs) {
            return new double2(lhs.x / rhs, lhs.y / rhs);
        }

        [MethodImpl(0x100)]
        public static double2 operator / (double lhs, double2 rhs) {
            return new double2(lhs / rhs.x, lhs / rhs.y);
        }

        // smaller
        [MethodImpl(0x100)]
        public static bool2 operator < (double2 lhs, double2 rhs) {
            return new bool2(lhs.x < rhs.x, lhs.y < rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator < (double2 lhs, double rhs) {
            return new bool2(lhs.x < rhs, lhs.y < rhs);
        }

        [MethodImpl(0x100)]
        public static bool2 operator < (double lhs, double2 rhs) {
            return new bool2(lhs < rhs.x, lhs < rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator <= (double2 lhs, double2 rhs) {
            return new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator <= (double2 lhs, double rhs) {
            return new bool2(lhs.x <= rhs, lhs.y <= rhs);
        }

        [MethodImpl(0x100)]
        public static bool2 operator <= (double lhs, double2 rhs) {
            return new bool2(lhs <= rhs.x, lhs <= rhs.y);
        }

        // greater
        [MethodImpl(0x100)]
        public static bool2 operator > (double2 lhs, double2 rhs) {
            return new bool2(lhs.x > rhs.x, lhs.y > rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator > (double2 lhs, double rhs) {
            return new bool2(lhs.x > rhs, lhs.y > rhs);
        }

        [MethodImpl(0x100)]
        public static bool2 operator > (double lhs, double2 rhs) {
            return new bool2(lhs > rhs.x, lhs > rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator >= (double2 lhs, double2 rhs) {
            return new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator >= (double2 lhs, double rhs) {
            return new bool2(lhs.x >= rhs, lhs.y >= rhs);
        }

        [MethodImpl(0x100)]
        public static bool2 operator >= (double lhs, double2 rhs) {
            return new bool2(lhs >= rhs.x, lhs >= rhs.y);
        }

        // neg
        [MethodImpl(0x100)]
        public static double2 operator - (double2 val) {
            return new double2(-val.x, -val.y);
        }

        // plus
        [MethodImpl(0x100)]
        public static double2 operator + (double2 val) {
            return new double2(+val.x, +val.y);
        }

        // equal
        [MethodImpl(0x100)]
        public static bool2 operator == (double2 lhs, double2 rhs) {
            return new bool2(lhs.x == rhs.x, lhs.y == rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator == (double2 lhs, double rhs) {
            return new bool2(lhs.x == rhs, lhs.y == rhs);
        }

        [MethodImpl(0x100)]
        public static bool2 operator == (double lhs, double2 rhs) {
            return new bool2(lhs == rhs.x, lhs == rhs.y);
        }

        // not equal
        [MethodImpl(0x100)]
        public static bool2 operator != (double2 lhs, double2 rhs) {
            return new bool2(lhs.x != rhs.x, lhs.y != rhs.y);
        }

        [MethodImpl(0x100)]
        public static bool2 operator != (double2 lhs, double rhs) {
            return new bool2(lhs.x != rhs, lhs.y != rhs);
        }

        [MethodImpl(0x100)]
        public static bool2 operator != (double lhs, double2 rhs) {
            return new bool2(lhs != rhs.x, lhs != rhs.y);
        }

        // Equals
        [MethodImpl(0x100)]
        public bool Equals (double2 rhs) {
            return x == rhs.x && y == rhs.y;
        }

        // [int index]
        unsafe public double this [int index] {
            get {
#if ENABLE_UNITY_COLLECTIONS_CHECKS

                if ((uint) index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif

                fixed (double2* array = &this) {
                    return ((double*) array)[index];
                }
            }

            set {
#if ENABLE_UNITY_COLLECTIONS_CHECKS

                if ((uint) index >= 2)
                    throw new ArgumentException("index must be between[0...1]");
#endif

                fixed (double* array = &x) {
                    array[index] = value;
                }
            }
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxxy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxyy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyxy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyyy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxxy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxyy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyxy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyyy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxx {
            [MethodImpl(0x100)]
            get {
                return new double3(x, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xxy {
            [MethodImpl(0x100)]
            get {
                return new double3(x, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyx {
            [MethodImpl(0x100)]
            get {
                return new double3(x, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xyy {
            [MethodImpl(0x100)]
            get {
                return new double3(x, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxx {
            [MethodImpl(0x100)]
            get {
                return new double3(y, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yxy {
            [MethodImpl(0x100)]
            get {
                return new double3(y, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyx {
            [MethodImpl(0x100)]
            get {
                return new double3(y, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yyy {
            [MethodImpl(0x100)]
            get {
                return new double3(y, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xx {
            [MethodImpl(0x100)]
            get {
                return new double2(x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 xy {
            [MethodImpl(0x100)]
            get {
                return new double2(x, y);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                y = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yx {
            [MethodImpl(0x100)]
            get {
                return new double2(y, x);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                x = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yy {
            [MethodImpl(0x100)]
            get {
                return new double2(y, y);
            }
        }
    }
}
