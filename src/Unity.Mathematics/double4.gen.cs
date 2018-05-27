// GENERATED CODE

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661
namespace Unity.Mathematics {
    public partial struct double4 : IEquatable<double4> {
        // mul
        [MethodImpl(0x100)]
        public static double4 operator * (double4 lhs, double4 rhs) {
            return new double4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        }

        [MethodImpl(0x100)]
        public static double4 operator * (double4 lhs, double rhs) {
            return new double4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        }

        [MethodImpl(0x100)]
        public static double4 operator * (double lhs, double4 rhs) {
            return new double4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        }

        // add
        [MethodImpl(0x100)]
        public static double4 operator + (double4 lhs, double4 rhs) {
            return new double4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        }

        [MethodImpl(0x100)]
        public static double4 operator + (double4 lhs, double rhs) {
            return new double4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        }

        [MethodImpl(0x100)]
        public static double4 operator + (double lhs, double4 rhs) {
            return new double4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        }

        // sub
        [MethodImpl(0x100)]
        public static double4 operator - (double4 lhs, double4 rhs) {
            return new double4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        }

        [MethodImpl(0x100)]
        public static double4 operator - (double4 lhs, double rhs) {
            return new double4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        }

        [MethodImpl(0x100)]
        public static double4 operator - (double lhs, double4 rhs) {
            return new double4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        }

        // div
        [MethodImpl(0x100)]
        public static double4 operator / (double4 lhs, double4 rhs) {
            return new double4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        }

        [MethodImpl(0x100)]
        public static double4 operator / (double4 lhs, double rhs) {
            return new double4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        }

        [MethodImpl(0x100)]
        public static double4 operator / (double lhs, double4 rhs) {
            return new double4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        }

        // smaller
        [MethodImpl(0x100)]
        public static bool4 operator < (double4 lhs, double4 rhs) {
            return new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator < (double4 lhs, double rhs) {
            return new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        }

        [MethodImpl(0x100)]
        public static bool4 operator < (double lhs, double4 rhs) {
            return new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator <= (double4 lhs, double4 rhs) {
            return new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator <= (double4 lhs, double rhs) {
            return new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        }

        [MethodImpl(0x100)]
        public static bool4 operator <= (double lhs, double4 rhs) {
            return new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        }

        // greater
        [MethodImpl(0x100)]
        public static bool4 operator > (double4 lhs, double4 rhs) {
            return new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator > (double4 lhs, double rhs) {
            return new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        }

        [MethodImpl(0x100)]
        public static bool4 operator > (double lhs, double4 rhs) {
            return new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator >= (double4 lhs, double4 rhs) {
            return new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator >= (double4 lhs, double rhs) {
            return new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        }

        [MethodImpl(0x100)]
        public static bool4 operator >= (double lhs, double4 rhs) {
            return new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        }

        // neg
        [MethodImpl(0x100)]
        public static double4 operator - (double4 val) {
            return new double4(-val.x, -val.y, -val.z, -val.w);
        }

        // plus
        [MethodImpl(0x100)]
        public static double4 operator + (double4 val) {
            return new double4(+val.x, +val.y, +val.z, +val.w);
        }

        // equal
        [MethodImpl(0x100)]
        public static bool4 operator == (double4 lhs, double4 rhs) {
            return new bool4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator == (double4 lhs, double rhs) {
            return new bool4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        }

        [MethodImpl(0x100)]
        public static bool4 operator == (double lhs, double4 rhs) {
            return new bool4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        }

        // not equal
        [MethodImpl(0x100)]
        public static bool4 operator != (double4 lhs, double4 rhs) {
            return new bool4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        }

        [MethodImpl(0x100)]
        public static bool4 operator != (double4 lhs, double rhs) {
            return new bool4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        }

        [MethodImpl(0x100)]
        public static bool4 operator != (double lhs, double4 rhs) {
            return new bool4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        }

        // Equals
        [MethodImpl(0x100)]
        public bool Equals (double4 rhs) {
            return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w;
        }

        // [int index]
        unsafe public double this [int index] {
            get {
#if ENABLE_UNITY_COLLECTIONS_CHECKS

                if ((uint) index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
#endif

                fixed (double4* array = &this) {
                    return ((double*) array)[index];
                }
            }

            set {
#if ENABLE_UNITY_COLLECTIONS_CHECKS

                if ((uint) index >= 4)
                    throw new ArgumentException("index must be between[0...3]");
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
        public double4 xxxw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, x, w);
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
        public double4 xxyw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, y, w);
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
        public double4 xxzw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxwx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxwy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxwz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xxww {
            [MethodImpl(0x100)]
            get {
                return new double4(x, x, w, w);
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
        public double4 xyxw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, x, w);
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
        public double4 xyyw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, y, w);
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
        public double4 xyzw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, z, w);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xywx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xywy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xywz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, w, z);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xyww {
            [MethodImpl(0x100)]
            get {
                return new double4(x, y, w, w);
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
        public double4 xzxw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, x, w);
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
        public double4 xzyw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, y, w);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
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
        public double4 xzzw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzwx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzwy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, w, y);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzwz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xzww {
            [MethodImpl(0x100)]
            get {
                return new double4(x, z, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwxw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, y, z);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwyw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, z, y);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwzw {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwwx {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwwy {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwwz {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 xwww {
            [MethodImpl(0x100)]
            get {
                return new double4(x, w, w, w);
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
        public double4 yxxw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, x, w);
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
        public double4 yxyw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, y, w);
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
        public double4 yxzw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, z, w);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxwx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxwy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxwz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, w, z);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yxww {
            [MethodImpl(0x100)]
            get {
                return new double4(y, x, w, w);
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
        public double4 yyxw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, x, w);
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
        public double4 yyyw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, y, w);
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
        public double4 yyzw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yywx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yywy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yywz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yyww {
            [MethodImpl(0x100)]
            get {
                return new double4(y, y, w, w);
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
        public double4 yzxw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, x, w);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
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
        public double4 yzyw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, y, w);
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
        public double4 yzzw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzwx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, w, x);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzwy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzwz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 yzww {
            [MethodImpl(0x100)]
            get {
                return new double4(y, z, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, x, z);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywxw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywyw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, z, x);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywzw {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywwx {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywwy {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywwz {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 ywww {
            [MethodImpl(0x100)]
            get {
                return new double4(y, w, w, w);
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
        public double4 zxxw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, x, w);
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
        public double4 zxyw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, y, w);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
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
        public double4 zxzw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxwx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxwy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, w, y);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxwz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zxww {
            [MethodImpl(0x100)]
            get {
                return new double4(z, x, w, w);
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
        public double4 zyxw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, x, w);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
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
        public double4 zyyw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, y, w);
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
        public double4 zyzw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zywx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, w, x);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zywy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zywz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zyww {
            [MethodImpl(0x100)]
            get {
                return new double4(z, y, w, w);
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
        public double4 zzxw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, x, w);
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
        public double4 zzyw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, y, w);
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
        public double4 zzzw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzwx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzwy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzwz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zzww {
            [MethodImpl(0x100)]
            get {
                return new double4(z, z, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, x, y);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwxw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, y, x);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwyw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwzw {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwwx {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwwy {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwwz {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 zwww {
            [MethodImpl(0x100)]
            get {
                return new double4(z, w, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxxw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, y, z);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxyw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, z, y);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxzw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxwx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxwy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxwz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wxww {
            [MethodImpl(0x100)]
            get {
                return new double4(w, x, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, x, z);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyxw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyyw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, z, x);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyzw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wywx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wywy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wywz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wyww {
            [MethodImpl(0x100)]
            get {
                return new double4(w, y, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, x, y);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzxw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, y, x);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzyw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzzw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzwx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzwy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzwz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wzww {
            [MethodImpl(0x100)]
            get {
                return new double4(w, z, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, x, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, x, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwxw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, y, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, y, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwyw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, z, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, z, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwzw {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwwx {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwwy {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwwz {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double4 wwww {
            [MethodImpl(0x100)]
            get {
                return new double4(w, w, w, w);
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
        public double3 xxw {
            [MethodImpl(0x100)]
            get {
                return new double3(x, x, w);
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
        public double3 xyw {
            [MethodImpl(0x100)]
            get {
                return new double3(x, y, w);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                y = value.y;
                w = value.z;
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
        public double3 xzw {
            [MethodImpl(0x100)]
            get {
                return new double3(x, z, w);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                z = value.y;
                w = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xwx {
            [MethodImpl(0x100)]
            get {
                return new double3(x, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xwy {
            [MethodImpl(0x100)]
            get {
                return new double3(x, w, y);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                w = value.y;
                y = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xwz {
            [MethodImpl(0x100)]
            get {
                return new double3(x, w, z);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                w = value.y;
                z = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 xww {
            [MethodImpl(0x100)]
            get {
                return new double3(x, w, w);
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
        public double3 yxw {
            [MethodImpl(0x100)]
            get {
                return new double3(y, x, w);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                x = value.y;
                w = value.z;
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
        public double3 yyw {
            [MethodImpl(0x100)]
            get {
                return new double3(y, y, w);
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
        public double3 yzw {
            [MethodImpl(0x100)]
            get {
                return new double3(y, z, w);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                z = value.y;
                w = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 ywx {
            [MethodImpl(0x100)]
            get {
                return new double3(y, w, x);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                w = value.y;
                x = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 ywy {
            [MethodImpl(0x100)]
            get {
                return new double3(y, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 ywz {
            [MethodImpl(0x100)]
            get {
                return new double3(y, w, z);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                w = value.y;
                z = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 yww {
            [MethodImpl(0x100)]
            get {
                return new double3(y, w, w);
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
        public double3 zxw {
            [MethodImpl(0x100)]
            get {
                return new double3(z, x, w);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                x = value.y;
                w = value.z;
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
        public double3 zyw {
            [MethodImpl(0x100)]
            get {
                return new double3(z, y, w);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                y = value.y;
                w = value.z;
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
        public double3 zzw {
            [MethodImpl(0x100)]
            get {
                return new double3(z, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zwx {
            [MethodImpl(0x100)]
            get {
                return new double3(z, w, x);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                w = value.y;
                x = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zwy {
            [MethodImpl(0x100)]
            get {
                return new double3(z, w, y);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                w = value.y;
                y = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zwz {
            [MethodImpl(0x100)]
            get {
                return new double3(z, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 zww {
            [MethodImpl(0x100)]
            get {
                return new double3(z, w, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxx {
            [MethodImpl(0x100)]
            get {
                return new double3(w, x, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxy {
            [MethodImpl(0x100)]
            get {
                return new double3(w, x, y);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                x = value.y;
                y = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxz {
            [MethodImpl(0x100)]
            get {
                return new double3(w, x, z);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                x = value.y;
                z = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wxw {
            [MethodImpl(0x100)]
            get {
                return new double3(w, x, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyx {
            [MethodImpl(0x100)]
            get {
                return new double3(w, y, x);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                y = value.y;
                x = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyy {
            [MethodImpl(0x100)]
            get {
                return new double3(w, y, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyz {
            [MethodImpl(0x100)]
            get {
                return new double3(w, y, z);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                y = value.y;
                z = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wyw {
            [MethodImpl(0x100)]
            get {
                return new double3(w, y, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzx {
            [MethodImpl(0x100)]
            get {
                return new double3(w, z, x);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                z = value.y;
                x = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzy {
            [MethodImpl(0x100)]
            get {
                return new double3(w, z, y);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                z = value.y;
                y = value.z;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzz {
            [MethodImpl(0x100)]
            get {
                return new double3(w, z, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wzw {
            [MethodImpl(0x100)]
            get {
                return new double3(w, z, w);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wwx {
            [MethodImpl(0x100)]
            get {
                return new double3(w, w, x);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wwy {
            [MethodImpl(0x100)]
            get {
                return new double3(w, w, y);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 wwz {
            [MethodImpl(0x100)]
            get {
                return new double3(w, w, z);
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double3 www {
            [MethodImpl(0x100)]
            get {
                return new double3(w, w, w);
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
        public double2 xw {
            [MethodImpl(0x100)]
            get {
                return new double2(x, w);
            }
            [MethodImpl(0x100)]
            set {
                x = value.x;
                w = value.y;
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
        public double2 yw {
            [MethodImpl(0x100)]
            get {
                return new double2(y, w);
            }
            [MethodImpl(0x100)]
            set {
                y = value.x;
                w = value.y;
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


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 zw {
            [MethodImpl(0x100)]
            get {
                return new double2(z, w);
            }
            [MethodImpl(0x100)]
            set {
                z = value.x;
                w = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 wx {
            [MethodImpl(0x100)]
            get {
                return new double2(w, x);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                x = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 wy {
            [MethodImpl(0x100)]
            get {
                return new double2(w, y);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                y = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 wz {
            [MethodImpl(0x100)]
            get {
                return new double2(w, z);
            }
            [MethodImpl(0x100)]
            set {
                w = value.x;
                z = value.y;
            }
        }


        [EditorBrowsable(EditorBrowsableState.Never)]
        public double2 ww {
            [MethodImpl(0x100)]
            get {
                return new double2(w, w);
            }
        }
    }
}