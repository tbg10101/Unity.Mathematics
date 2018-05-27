// GENERATED CODE

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661
namespace Unity.Mathematics {
    public partial struct double3 : IEquatable<double3> {
        // mul
        [MethodImpl(0x100)]
        public static double3 operator * (double3 lhs, double3 rhs) {
            return new double3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        }

        [MethodImpl(0x100)]
        public static double3 operator * (double3 lhs, double rhs) {
            return new double3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        }

        [MethodImpl(0x100)]
        public static double3 operator * (double lhs, double3 rhs) {
            return new double3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        }

        // add
        [MethodImpl(0x100)]
        public static double3 operator + (double3 lhs, double3 rhs) {
            return new double3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        [MethodImpl(0x100)]
        public static double3 operator + (double3 lhs, double rhs) {
            return new double3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        }

        [MethodImpl(0x100)]
        public static double3 operator + (double lhs, double3 rhs) {
            return new double3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        }

        // sub
        [MethodImpl(0x100)]
        public static double3 operator - (double3 lhs, double3 rhs) {
            return new double3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        [MethodImpl(0x100)]
        public static double3 operator - (double3 lhs, double rhs) {
            return new double3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        }

        [MethodImpl(0x100)]
        public static double3 operator - (double lhs, double3 rhs) {
            return new double3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        }

        // div
        [MethodImpl(0x100)]
        public static double3 operator / (double3 lhs, double3 rhs) {
            return new double3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        }

        [MethodImpl(0x100)]
        public static double3 operator / (double3 lhs, double rhs) {
            return new double3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        }

        [MethodImpl(0x100)]
        public static double3 operator / (double lhs, double3 rhs) {
            return new double3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        }

        // smaller
        [MethodImpl(0x100)]
        public static bool3 operator < (double3 lhs, double3 rhs) {
            return new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator < (double3 lhs, double rhs) {
            return new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        }

        [MethodImpl(0x100)]
        public static bool3 operator < (double lhs, double3 rhs) {
            return new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator <= (double3 lhs, double3 rhs) {
            return new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator <= (double3 lhs, double rhs) {
            return new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        }

        [MethodImpl(0x100)]
        public static bool3 operator <= (double lhs, double3 rhs) {
            return new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        }

        // greater
        [MethodImpl(0x100)]
        public static bool3 operator > (double3 lhs, double3 rhs) {
            return new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator > (double3 lhs, double rhs) {
            return new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        }

        [MethodImpl(0x100)]
        public static bool3 operator > (double lhs, double3 rhs) {
            return new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator >= (double3 lhs, double3 rhs) {
            return new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator >= (double3 lhs, double rhs) {
            return new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        }

        [MethodImpl(0x100)]
        public static bool3 operator >= (double lhs, double3 rhs) {
            return new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        }

        // neg
        [MethodImpl(0x100)]
        public static double3 operator - (double3 val) {
            return new double3(-val.x, -val.y, -val.z);
        }

        // plus
        [MethodImpl(0x100)]
        public static double3 operator + (double3 val) {
            return new double3(+val.x, +val.y, +val.z);
        }

        // equal
        [MethodImpl(0x100)]
        public static bool3 operator == (double3 lhs, double3 rhs) {
            return new bool3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator == (double3 lhs, double rhs) {
            return new bool3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        }

        [MethodImpl(0x100)]
        public static bool3 operator == (double lhs, double3 rhs) {
            return new bool3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        }

        // not equal
        [MethodImpl(0x100)]
        public static bool3 operator != (double3 lhs, double3 rhs) {
            return new bool3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        }

        [MethodImpl(0x100)]
        public static bool3 operator != (double3 lhs, double rhs) {
            return new bool3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        }

        [MethodImpl(0x100)]
        public static bool3 operator != (double lhs, double3 rhs) {
            return new bool3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        }

        // Equals
        [MethodImpl(0x100)]
        public bool Equals (double3 rhs) {
            return x == rhs.x && y == rhs.y && z == rhs.z;
        }

        // [int index]
        unsafe public double this [int index] {
            get {
#if ENABLE_UNITY_COLLECTIONS_CHECKS

                if ((uint) index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
#endif

                fixed (double3* array = &this) {
                    return ((double*) array)[index];
                }
            }

            set {
#if ENABLE_UNITY_COLLECTIONS_CHECKS

                if ((uint) index >= 3)
                    throw new ArgumentException("index must be between[0...2]");
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
        public double4 xxxz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, x, z);
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
        public double4 xxyz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxzz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, z, z);
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
        public double4 xyxz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, x, z);
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
        public double4 xyyz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyzz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzxz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzyz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzzz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, z, z);
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
        public double4 yxxz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, x, z);
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
        public double4 yxyz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxzz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, z, z);
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
        public double4 yyxz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, x, z);
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
        public double4 yyyz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyzz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzxz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzyz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzzz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxxz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxyz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxzz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyxz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyyz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyzz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzxz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzyz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzzz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, z, z);
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
        public double3 xxz {
            [MethodImpl(0x100)]
            get {
                return new double3(x, x, z);
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
        public double3 xyz {
            [MethodImpl(0x100)]
            get {
                return new double3(x, y, z);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzx {
            [MethodImpl(0x100)]
            get {
                return new double3(x, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzy {
            [MethodImpl(0x100)]
            get {
                return new double3(x, z, y);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xzz {
            [MethodImpl(0x100)]
            get {
                return new double3(x, z, z);
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
        public double3 yxz {
            [MethodImpl(0x100)]
            get {
                return new double3(y, x, z);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                x = value.y;
                z = value.z;
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
        public double3 yyz {
            [MethodImpl(0x100)]
            get {
                return new double3(y, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzx {
            [MethodImpl(0x100)]
            get {
                return new double3(y, z, x);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzy {
            [MethodImpl(0x100)]
            get {
                return new double3(y, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yzz {
            [MethodImpl(0x100)]
            get {
                return new double3(y, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxx {
            [MethodImpl(0x100)]
            get {
                return new double3(z, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxy {
            [MethodImpl(0x100)]
            get {
                return new double3(z, x, y);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zxz {
            [MethodImpl(0x100)]
            get {
                return new double3(z, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyx {
            [MethodImpl(0x100)]
            get {
                return new double3(z, y, x);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyy {
            [MethodImpl(0x100)]
            get {
                return new double3(z, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zyz {
            [MethodImpl(0x100)]
            get {
                return new double3(z, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzx {
            [MethodImpl(0x100)]
            get {
                return new double3(z, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzy {
            [MethodImpl(0x100)]
            get {
                return new double3(z, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zzz {
            [MethodImpl(0x100)]
            get {
                return new double3(z, z, z);
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
        public double2 xz {
            [MethodImpl(0x100)]
            get {
                return new double2(x, z);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                z = value.y;
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


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 yz {
            [MethodImpl(0x100)]
            get {
                return new double2(y, z);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                z = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zx {
            [MethodImpl(0x100)]
            get {
                return new double2(z, x);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                x = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zy {
            [MethodImpl(0x100)]
            get {
                return new double2(z, y);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                y = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zz {
            [MethodImpl(0x100)]
            get {
                return new double2(z, z);
            }
        }
    }
}