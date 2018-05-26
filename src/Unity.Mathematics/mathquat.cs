using System;
using Unity.Mathematics.Experimental;

namespace Unity.Mathematics {
    [Serializable]
    public struct quaternion_d {
        public double4 value;

        public quaternion_d (double x, double y, double z, double w) {
            value.x = x;
            value.y = y;
            value.z = z;
            value.w = w;
        }

        public quaternion_d (double4 value) {
            this.value = value;
        }

        public static quaternion_d identity => new quaternion_d(0.0, 0.0, 0.0, 1.0);

        public static implicit operator quaternion_d (quaternion q) {
            return new quaternion_d(q.value);
        }

        // loss of precision should be explicit
        public quaternion toQuaternion () {
            return new quaternion(value.toFloat4());
        }
    }

    public static partial class math_x {
        public static quaternion_d normalize (quaternion_d q) {
            double4 value = q.value;
            double len = dot(value, value);

            // note we use float4 comparison here because this gives us -1 / 0 which is necessary for select.
            //return select(quatIdentity(), q*rsqrt(len), len > float4(epsilon_normal()));
            value = @select(quaternion.identity.value, value * rsqrt(len), len > math.epsilon_normal);

            return new quaternion_d(value);
        }

        public static quaternion_d mul (quaternion_d lhs, quaternion_d rhs) {
            return new quaternion_d(
                lhs.value.w * rhs.value.x + lhs.value.x * rhs.value.w + lhs.value.y * rhs.value.z - lhs.value.z * rhs.value.y,
                lhs.value.w * rhs.value.y + lhs.value.y * rhs.value.w + lhs.value.z * rhs.value.x - lhs.value.x * rhs.value.z,
                lhs.value.w * rhs.value.z + lhs.value.z * rhs.value.w + lhs.value.x * rhs.value.y - lhs.value.y * rhs.value.x,
                lhs.value.w * rhs.value.w - lhs.value.x * rhs.value.x - lhs.value.y * rhs.value.y - lhs.value.z * rhs.value.z);
        }

        public static double3 mul (quaternion_d rotation, double3 position) {
            double x = rotation.value.x * 2F;
            double y = rotation.value.y * 2F;
            double z = rotation.value.z * 2F;
            double xx = rotation.value.x * x;
            double yy = rotation.value.y * y;
            double zz = rotation.value.z * z;
            double xy = rotation.value.x * y;
            double xz = rotation.value.x * z;
            double yz = rotation.value.y * z;
            double wx = rotation.value.w * x;
            double wy = rotation.value.w * y;
            double wz = rotation.value.w * z;

            double3 res;
            res.x = (1F - (yy + zz)) * position.x + (xy - wz) * position.y + (xz + wy) * position.z;
            res.y = (xy + wz) * position.x + (1F - (xx + zz)) * position.y + (yz - wx) * position.z;
            res.z = (xz - wy) * position.x + (yz + wx) * position.y + (1F - (xx + yy)) * position.z;
            return res;
        }

        // get unit quaternion from rotation matrix
        // u, v, w must be ortho-normal.
        public static quaternion_d matrixToQuat (double3 u, double3 v, double3 w) {
            double4 q;
            if (u.x >= 0f) {
                double t = v.y + w.z;
                if (t >= 0f)
                    q = new double4(v.z - w.y, w.x - u.z, u.y - v.x, 1f + u.x + t);
                else
                    q = new double4(1f + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
            } else {
                double t = v.y - w.z;
                if (t >= 0f)
                    q = new double4(u.y + v.x, 1f - u.x + t, v.z + w.y, w.x - u.z);
                else
                    q = new double4(w.x + u.z, v.z + w.y, 1f - u.x - t, u.y - v.x);
            }

            return normalize(new quaternion_d(q));
        }

        public static double3x3 quatToMatrix (quaternion_d q) {
            q = normalize(q);

            // Precalculate coordinate products
            double x = q.value.x * 2.0F;
            double y = q.value.y * 2.0F;
            double z = q.value.z * 2.0F;
            double xx = q.value.x * x;
            double yy = q.value.y * y;
            double zz = q.value.z * z;
            double xy = q.value.x * y;
            double xz = q.value.x * z;
            double yz = q.value.y * z;
            double wx = q.value.w * x;
            double wy = q.value.w * y;
            double wz = q.value.w * z;

            // Calculate 3x3 matrix from orthonormal basis
            var m = new double3x3 {
                m0 = new double3(1.0f - (yy + zz), xy + wz, xz - wy),
                m1 = new double3(xy - wz, 1.0f - (xx + zz), yz + wx),
                m2 = new double3(xz + wy, yz - wx, 1.0f - (xx + yy))
            };
            return m;
        }

        public static double4x4 rottrans (quaternion_d q, double3 t) {
            var m3x3 = quatToMatrix(q);
            var m = new double4x4 {
                m0 = new double4(m3x3.m0, 0.0f),
                m1 = new double4(m3x3.m1, 0.0f),
                m2 = new double4(m3x3.m2, 0.0f),
                m3 = new double4(t, 1.0f)
            };
            return m;
        }

        public static quaternion_d axisAngle (double3 axis, double angle) {
            double3 axisUnit = normalize(axis);
            double sina = sin(0.5f * angle);
            double cosa = cos(0.5f * angle);
            return new quaternion_d {value = new double4(axisUnit.x * sina, axisUnit.y * sina, axisUnit.z * sina, cosa)};
        }

        public static quaternion_d euler (double3 eulerInDegrees) {
            throw new NotImplementedException();
        }

        public static quaternion_d euler (double x, double y, double z) {
            throw new NotImplementedException();
        }

        //@TODO: Decide on saturate for t (old math lib did it...)

        public static quaternion_d slerp (quaternion_d lhs, quaternion_d rhs, double t) {
            throw new NotImplementedException();
        }

        public static quaternion_d lerp (quaternion_d lhs, quaternion_d rhs, double t) {
            throw new NotImplementedException();
            // var res = math.normalize(lhs.value + t * (math.chgsign(rhs.value, math.dot(lhs.value, rhs.value)) - rhs.value));
            // return new quaternion_d(res);
        }

        public static double3 forward (quaternion_d q) {
            return mul(q, new double3(0, 0, 1));
        }

        public static double3 up (quaternion_d q) {
            return mul(q, new double3(0, 1, 0));
        }

        public static quaternion_d lookRotationToQuaternion (double3 direction, double3 up) {
            var vector = math_experimental_x.normalizeSafe(direction);
            var vector2 = cross(up, vector);
            var vector3 = cross(vector, vector2);
            var m00 = vector2.x;
            var m01 = vector2.y;
            var m02 = vector2.z;
            var m10 = vector3.x;
            var m11 = vector3.y;
            var m12 = vector3.z;
            var m20 = vector.x;
            var m21 = vector.y;
            var m22 = vector.z;
            var num8 = (m00 + m11) + m22;
            double4 q;
            if (num8 > 0.0) {
                var num = sqrt(num8 + 1.0f);
                q.w = num * 0.5f;
                num = 0.5f / num;
                q.x = (m12 - m21) * num;
                q.y = (m20 - m02) * num;
                q.z = (m01 - m10) * num;
                return new quaternion_d(q);
            }

            if ((m00 >= m11) && (m00 >= m22)) {
                var num7 = sqrt(((1.0f + m00) - m11) - m22);
                var num4 = 0.5f / num7;
                q.x = 0.5f * num7;
                q.y = (m01 + m10) * num4;
                q.z = (m02 + m20) * num4;
                q.w = (m12 - m21) * num4;
                return new quaternion_d(q);
            }

            if (m11 > m22) {
                var num6 = sqrt(((1.0f + m11) - m00) - m22);
                var num3 = 0.5f / num6;
                q.x = (m10 + m01) * num3;
                q.y = 0.5f * num6;
                q.z = (m21 + m12) * num3;
                q.w = (m20 - m02) * num3;
                return new quaternion_d(q);
            }

            var num5 = sqrt(((1.0f + m22) - m00) - m11);
            var num2 = 0.5f / num5;
            q.x = (m20 + m02) * num2;
            q.y = (m21 + m12) * num2;
            q.z = 0.5f * num5;
            q.w = (m01 - m10) * num2;
            return new quaternion_d(q);
        }
    }
}