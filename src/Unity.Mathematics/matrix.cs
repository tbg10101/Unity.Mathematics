namespace Unity.Mathematics {
    public struct double4x4 {
        public double4 m0;
        public double4 m1;
        public double4 m2;
        public double4 m3;

        public double4x4 (double4 m0, double4 m1, double4 m2, double4 m3) {
            this.m0 = m0;
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public double4x4 (
            double m00,
            double m01,
            double m02,
            double m03,
            double m10,
            double m11,
            double m12,
            double m13,
            double m20,
            double m21,
            double m22,
            double m23,
            double m30,
            double m31,
            double m32,
            double m33) {

            m0 = new double4(m00, m01, m02, m03);
            m1 = new double4(m10, m11, m12, m13);
            m2 = new double4(m20, m21, m22, m23);
            m3 = new double4(m30, m31, m32, m33);
        }

        public static double4x4 operator * (double4x4 mat, double s) {
            return new double4x4(mat.m0 * s, mat.m1 * s, mat.m2 * s, mat.m3 * s);
        }

        public static double4x4 identity => new double4x4 {
            m0 = new double4(1.0f, 0.0f, 0.0f, 0.0f),
            m1 = new double4(0.0f, 1.0f, 0.0f, 0.0f),
            m2 = new double4(0.0f, 0.0f, 1.0f, 0.0f),
            m3 = new double4(0.0f, 0.0f, 0.0f, 1.0f)
        };
    }

    public struct double2x2 {
        public double2 m0;
        public double2 m1;

        public double2x2 (double2 m0, double2 m1) {
            this.m0 = m0;
            this.m1 = m1;
        }

        public double2x2 (
            double m00,
            double m01,
            double m10,
            double m11) {

            m0 = new double2(m00, m01);
            m1 = new double2(m10, m11);
        }

        public static double2x2 operator * (double2x2 mat, double s) {
            return new double2x2(mat.m0 * s, mat.m1 * s);
        }
    }

    public struct double3x3 {
        public double3 m0;
        public double3 m1;
        public double3 m2;

        public double3x3 (double3 m0, double3 m1, double3 m2) {
            this.m0 = m0;
            this.m1 = m1;
            this.m2 = m2;
        }

        public double3x3 (
            double m00,
            double m01,
            double m02,
            double m10,
            double m11,
            double m12,
            double m20,
            double m21,
            double m22) {

            m0 = new double3(m00, m01, m02);
            m1 = new double3(m10, m11, m12);
            m2 = new double3(m20, m21, m22);
        }

        public static double3x3 operator * (double3x3 mat, double s) {
            return new double3x3(mat.m0 * s, mat.m1 * s, mat.m2 * s);
        }
    }

    partial class math_x {
        public static double4 mul (double4x4 x, double4 v) {
            return mad(x.m0, v.x, x.m1 * v.y) + mad(x.m2, v.z, x.m3 * v.w);
        }

        public static double4x4 mul (double4x4 a, double4x4 b) {
            return new double4x4(mul(a, b.m0), mul(a, b.m1), mul(a, b.m2), mul(a, b.m3));
        }

        public static double2 mul (double2x2 x, double2 v) {
            return mad(x.m0, v.x, x.m1 * v.y);
        }

        public static double2x2 mul (double2x2 a, double2x2 b) {
            return new double2x2(mul(a, b.m0), mul(a, b.m1));
        }

        public static double3 mul (double3x3 x, double3 v) {
            return mad(x.m2, v.z, mad(x.m0, v.x, x.m1 * v.y));
        }

        public static double3x3 mul (double3x3 a, double3x3 b) {
            return new double3x3(mul(a, b.m0), mul(a, b.m1), mul(a, b.m2));
        }

        public static double3x3 orthogonalize (double3x3 i) {
            double3x3 o;

            double3 u = i.m0;
            double3 v = i.m1 - i.m0 * dot(i.m1, i.m0);

            double lenU = length(u);
            double lenV = length(v);

            bool c = lenU > math.epsilon_normal && lenV > math.epsilon_normal;

            o.m0 = select(new double3(1, 0, 0), u / lenU, c);
            o.m1 = select(new double3(0, 1, 0), v / lenV, c);
            o.m2 = cross(o.m0, o.m1);

            return o;
        }

        public static double2x2 transpose (double2x2 i) {
            return new double2x2(i.m0.x, i.m1.x, i.m0.y, i.m1.y);
        }

        public static double3x3 transpose (double3x3 i) {
            return new double3x3(i.m0.x, i.m1.x, i.m2.x, i.m0.y, i.m1.y, i.m2.y, i.m0.z, i.m1.z, i.m2.z);
        }

        public static double4x4 transpose (double4x4 i) {
            return new double4x4(
                i.m0.x,
                i.m1.x,
                i.m2.x,
                i.m3.x,
                i.m0.y,
                i.m1.y,
                i.m2.y,
                i.m3.y,
                i.m0.z,
                i.m1.z,
                i.m2.z,
                i.m3.z,
                i.m0.w,
                i.m1.w,
                i.m2.w,
                i.m3.w);
        }

        public static double4x4 scale (double3 vector) {
            double4x4 matrix4x4 = new double4x4 {
                m0 = new double4(vector.x, 0.0f, 0.0f, 0.0f),
                m1 = new double4(0.0f, vector.y, 0.0f, 0.0f),
                m2 = new double4(0.0f, 0.0f, vector.z, 0.0f),
                m3 = new double4(0.0f, 0.0f, 0.0f, 1.0f)
            };
            return matrix4x4;
        }

        public static double4x4 translate (double3 vector) {
            double4x4 matrix4x4 = new double4x4 {
                m0 = new double4(1.0f, 0.0f, 0.0f, 0.0f),
                m1 = new double4(0.0f, 1.0f, 0.0f, 0.0f),
                m2 = new double4(0.0f, 0.0f, 1.0f, 0.0f),
                m3 = new double4(vector.x, vector.y, vector.z, 1.0f)
            };
            return matrix4x4;
        }

        public static double3x3 identity3d => new double3x3(new double3(1, 0, 0), new double3(0, 1, 0), new double3(0, 0, 1));

        public static double4x4 identity4d => new double4x4(new double4(1, 0, 0, 0), new double4(0, 1, 0, 0), new double4(0, 0, 1, 0), new double4(0, 0, 0, 1));

        public static double4x4 lookRotationToMatrix (double3 position, double3 forward, double3 up) {
            double3x3 rot = lookRotationToMatrix(forward, up);

            double4x4 matrix;
            matrix.m0 = new double4(rot.m0, 0.0F);
            matrix.m1 = new double4(rot.m1, 0.0F);
            matrix.m2 = new double4(rot.m2, 0.0F);
            matrix.m3 = new double4(position, 1.0F);

            return matrix;
        }

        public static double3x3 lookRotationToMatrix (double3 forward, double3 up) {
            double3 z = forward;
            // compute u0
            double mag = length(z);
            if (mag < epsilon_d)
                return identity3d;
            z /= mag;

            double3 x = cross(up, z);
            mag = length(x);
            if (mag < epsilon_d)
                return identity3d;
            x /= mag;

            double3 y = cross(z, x);
            double yLength = length(y);
            if (yLength < 0.9F || yLength > 1.1F)
                return identity3d;

            return new double3x3(x, y, z);
        }

        /* @TODO:
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double determinant(double2x2 x) { throw new System.NotImplementedException(); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double determinant(double3x3 x) { throw new System.NotImplementedException(); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double determinant(double4x4 x) { throw new System.NotImplementedException(); }
        */
    }
}