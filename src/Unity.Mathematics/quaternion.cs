using System;
using Unity.Mathematics.Experimental;
using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;
using static Unity.Mathematics.math_x;

namespace Unity.Mathematics {
	[Serializable]
	public partial struct quaternion_d {
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

		// Construct unit quaternion_d from rotation matrix. The matrix must be orthonormal.
		public quaternion_d (double3x3 m) {
			double3 u = m.c0;
			double3 v = m.c1;
			double3 w = m.c2;

			if (u.x >= 0f) {
				double t = v.y + w.z;
				if (t >= 0f)
					value = double4(v.z - w.y, w.x - u.z, u.y - v.x, 1f + u.x + t);
				else
					value = new double4(1f + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
			} else {
				double t = v.y - w.z;
				if (t >= 0f)
					value = new double4(u.y + v.x, 1f - u.x + t, v.z + w.y, w.x - u.z);
				else
					value = new double4(w.x + u.z, v.z + w.y, 1f - u.x - t, u.y - v.x);
			}

			value = normalize(value);
		}

		// Construct unit quaternion_d from rigid-transformation matrix. The matrix must be orthonormal.
		public quaternion_d (double4x4 m) {
			double4 u = m.c0;
			double4 v = m.c1;
			double4 w = m.c2;

			if (u.x >= 0f) {
				double t = v.y + w.z;
				if (t >= 0f)
					value = double4(v.z - w.y, w.x - u.z, u.y - v.x, 1f + u.x + t);
				else
					value = double4(1f + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
			} else {
				double t = v.y - w.z;
				if (t >= 0f)
					value = double4(u.y + v.x, 1f - u.x + t, v.z + w.y, w.x - u.z);
				else
					value = double4(w.x + u.z, v.z + w.y, 1f - u.x - t, u.y - v.x);
			}

			value = normalize(value);
		}

		public static readonly quaternion_d identity = new quaternion_d(0.0f, 0.0f, 0.0f, 1.0f);

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d axisAngle (double3 axis, double angle) {
			double sina, cosa;
			sincos(0.5 * angle, out sina, out cosa);
			return quaternion_d(double4(normalize(axis) * sina, cosa));
		}

		public static quaternion_d eulerXYZ (double3 xyz) {
			// return mul(rotateZ(xyz.z), mul(rotateY(xyz.y), rotateX(xyz.x)));
			double3 s, c;
			sincos(0.5 * xyz, out s, out c);
			return quaternion_d(
				// s.x * c.y * c.z - s.y * s.z * c.x,
				// s.y * c.x * c.z + s.x * s.z * c.y,
				// s.z * c.x * c.y - s.x * s.y * c.z,
				// c.x * c.y * c.z + s.y * s.z * s.x
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(-1.0f, 1.0f, -1.0f, 1.0f)
			);
		}

		public static quaternion_d eulerXZY (double3 xyz) {
			// return mul(rotateY(xyz.y), mul(rotateZ(xyz.z), rotateX(xyz.x)));
			double3 s, c;
			sincos(0.5f * xyz, out s, out c);
			return quaternion_d(
				// s.x * c.y * c.z + s.y * s.z * c.x,
				// s.y * c.x * c.z + s.x * s.z * c.y,
				// s.z * c.x * c.y - s.x * s.y * c.z,
				// c.x * c.y * c.z - s.y * s.z * s.x
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(1.0f, 1.0f, -1.0f, -1.0f)
			);
		}

		public static quaternion_d eulerYXZ (double3 xyz) {
			// return mul(rotateZ(xyz.z), mul(rotateX(xyz.x), rotateY(xyz.y)));
			double3 s, c;
			sincos(0.5f * xyz, out s, out c);
			return quaternion_d(
				// s.x * c.y * c.z - s.y * s.z * c.x,
				// s.y * c.x * c.z + s.x * s.z * c.y,
				// s.z * c.x * c.y + s.x * s.y * c.z,
				// c.x * c.y * c.z - s.y * s.z * s.x
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(-1.0f, 1.0f, 1.0f, -1.0f)
			);
		}

		public static quaternion_d eulerYZX (double3 xyz) {
			// return mul(rotateX(xyz.x), mul(rotateZ(xyz.z), rotateY(xyz.y)));
			double3 s, c;
			sincos(0.5f * xyz, out s, out c);
			return quaternion_d(
				// s.x * c.y * c.z - s.y * s.z * c.x,
				// s.y * c.x * c.z - s.x * s.z * c.y,
				// s.z * c.x * c.y + s.x * s.y * c.z,
				// c.x * c.y * c.z + s.y * s.z * s.x
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(-1.0f, -1.0f, 1.0f, 1.0f)
			);
		}

		public static quaternion_d eulerZXY (double3 xyz) {
			// return mul(rotateY(xyz.y), mul(rotateX(xyz.x), rotateZ(xyz.z)));
			double3 s, c;
			sincos(0.5f * xyz, out s, out c);
			return quaternion_d(
				// s.x * c.y * c.z + s.y * s.z * c.x,
				// s.y * c.x * c.z - s.x * s.z * c.y,
				// s.z * c.x * c.y - s.x * s.y * c.z,
				// c.x * c.y * c.z + s.y * s.z * s.x
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(1.0f, -1.0f, -1.0f, 1.0f)
			);
		}

		public static quaternion_d eulerZYX (double3 xyz) {
			// return mul(rotateX(xyz.x), mul(rotateY(xyz.y), rotateZ(xyz.z)));
			double3 s, c;
			sincos(0.5f * xyz, out s, out c);
			return quaternion_d(
				// s.x * c.y * c.z + s.y * s.z * c.x,
				// s.y * c.x * c.z - s.x * s.z * c.y,
				// s.z * c.x * c.y + s.x * s.y * c.z,
				// c.x * c.y * c.z - s.y * s.x * s.z
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(1.0f, -1.0f, 1.0f, -1.0f)
			);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d eulerXYZ (double x, double y, double z) {
			return eulerXYZ(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d eulerXZY (double x, double y, double z) {
			return eulerXZY(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d eulerYXZ (double x, double y, double z) {
			return eulerYXZ(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d eulerYZX (double x, double y, double z) {
			return eulerYZX(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d eulerZXY (double x, double y, double z) {
			return eulerZXY(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d eulerZYX (double x, double y, double z) {
			return eulerZYX(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d euler (double x, double y, double z) {
			return eulerZYX(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d rotateX (double angle) {
			double sina, cosa;
			sincos(0.5 * angle, out sina, out cosa);
			return quaternion_d(sina, 0.0, 0.0, cosa);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d rotateY (double angle) {
			double sina, cosa;
			sincos(0.5 * angle, out sina, out cosa);
			return quaternion_d(0.0, sina, 0.0, cosa);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d rotateZ (double angle) {
			double sina, cosa;
			sincos(0.5 * angle, out sina, out cosa);
			return quaternion_d(0.0, 0.0, sina, cosa);
		}

		public static quaternion_d lookRotation (double3 direction, double3 up) {
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
				var num = sqrt(num8 + 1.0);
				q.w = num * 0.5;
				num = 0.5 / num;
				q.x = (m12 - m21) * num;
				q.y = (m20 - m02) * num;
				q.z = (m01 - m10) * num;
				return quaternion_d(q);
			}

			if ((m00 >= m11) && (m00 >= m22)) {
				var num7 = sqrt(((1.0 + m00) - m11) - m22);
				var num4 = 0.5 / num7;
				q.x = 0.5 * num7;
				q.y = (m01 + m10) * num4;
				q.z = (m02 + m20) * num4;
				q.w = (m12 - m21) * num4;
				return quaternion_d(q);
			}

			if (m11 > m22) {
				var num6 = sqrt(((1.0 + m11) - m00) - m22);
				var num3 = 0.5 / num6;
				q.x = (m10 + m01) * num3;
				q.y = 0.5 * num6;
				q.z = (m21 + m12) * num3;
				q.w = (m20 - m02) * num3;
				return quaternion_d(q);
			}

			var num5 = sqrt(((1.0 + m22) - m00) - m11);
			var num2 = 0.5 / num5;
			q.x = (m20 + m02) * num2;
			q.y = (m21 + m12) * num2;
			q.z = 0.5 * num5;
			q.w = (m01 - m10) * num2;
			return quaternion_d(q);
		}

		public static implicit operator quaternion_d (quaternion q) {
			return new quaternion_d(q.value);
		}

		public quaternion toQuaternion () { // loss of precision should be explicit
			return new quaternion(value.toFloat4());
		}

		public Quaternion toEngineQuaternion () {
			return new Quaternion((float) value.x, (float) value.y, (float) value.z, (float) value.w);
		}

		public static implicit operator double4 (quaternion_d q) {
			return q.value;
		}

		public static implicit operator quaternion_d (double4 d) {
			return quaternion_d(d);
		}
	}

	public static partial class math_x {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d quaternion_d (double x, double y, double z, double w) {
			return new quaternion_d(x, y, z, w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d quaternion_d (double4 value) {
			return new quaternion_d(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d quaternion_d (double3x3 m) {
			return new quaternion_d(m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d quaternion_d (double4x4 m) {
			return new quaternion_d(m);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d conjugate (quaternion_d q) {
			return quaternion_d(q.value * double4(-1.0, -1.0, -1.0, 1.0)); // TODO: should only be one xorps
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d inverse (quaternion_d q) {
			return conjugate(normalize(q));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double dot (quaternion_d a, quaternion_d b) {
			return dot(a.value, b.value);
		}

		public static quaternion_d normalize (quaternion_d q) {
			double4 value = q.value;
			double len = dot(value, value);
			value = select(Mathematics.quaternion_d.identity.value, value * rsqrt(len), len > epsilon_normal);

			return quaternion_d(value);
		}

		public static quaternion_d mul (quaternion_d a, quaternion_d b) {
			return quaternion_d(
				a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * double4(1.0f, 1.0f, 1.0f, -1.0f) -
				a.value.zxyz * b.value.yzxz);
		}

		public static double3 mul (quaternion_d q, double3 vector) {
			double3 t = 2 * cross(q.value.xyz, vector);
			return vector + q.value.w * t + cross(q.value.xyz, t);
		}

		public static quaternion_d nlerp (quaternion_d q1, quaternion_d q2, double t) {
			double dt = dot(q1, q2);
			if (dt < 0.0f) {
				q2.value = -q2.value;
			}

			return normalize(quaternion_d(lerp(q1.value, q2.value, t)));
		}

		public static quaternion_d slerp (quaternion_d q1, quaternion_d q2, double t) {
			double dt = dot(q1, q2);
			if (dt < 0.0f) {
				dt = -dt;
				q2.value = -q2.value;
			}

			if (dt < 0.9995f) {
				double angle = acos(dt);
				double s = rsqrt(1.0f - dt * dt); // 1.0f / sin(angle)
				double w1 = sin(angle * (1.0f - t)) * s;
				double w2 = sin(angle * t) * s;
				return quaternion_d(q1.value * w1 + q2.value * w2);
			} else {
				// if the angle is small, use linear interpolation
				return nlerp(q1, q2, t);
			}
		}

		public static double3 forward (quaternion_d q) {
			return mul(q, double3(0, 0, 1));
		}

		public static double3 up (quaternion_d q) {
			return mul(q, double3(0, 1, 0));
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

			// Pre-calculate coordinate products
			double x = q.value.x * 2.0;
			double y = q.value.y * 2.0;
			double z = q.value.z * 2.0;
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
				c0 = new double3(1.0 - (yy + zz), xy + wz, xz - wy),
				c1 = new double3(xy - wz, 1.0 - (xx + zz), yz + wx),
				c2 = new double3(xz + wy, yz - wx, 1.0 - (xx + yy))
			};
			return m;
		}

		public static double4x4 rottrans (quaternion_d q, double3 t) {
			var m3x3 = quatToMatrix(q);
			var m = new double4x4 {
				c0 = new double4(m3x3.c0, 0.0),
				c1 = new double4(m3x3.c1, 0.0),
				c2 = new double4(m3x3.c2, 0.0),
				c3 = new double4(t, 1.0)
			};
			return m;
		}
	}
}
