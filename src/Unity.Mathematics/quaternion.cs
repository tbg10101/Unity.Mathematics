using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;
using static Unity.Mathematics.math_x;

namespace Unity.Mathematics {
	[Serializable]
	public struct quaternion_d : IEquatable<quaternion_d>, IFormattable {
		public static readonly quaternion_d identity = new quaternion_d(0.0, 0.0, 0.0, 1.0);
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

			if (u.x >= 0.0) {
				double t = v.y + w.z;
				if (t >= 0.0)
					value = double4(v.z - w.y, w.x - u.z, u.y - v.x, 1.0 + u.x + t);
				else
					value = new double4(1.0 + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
			} else {
				double t = v.y - w.z;
				if (t >= 0.0)
					value = new double4(u.y + v.x, 1.0 - u.x + t, v.z + w.y, w.x - u.z);
				else
					value = new double4(w.x + u.z, v.z + w.y, 1.0 - u.x - t, u.y - v.x);
			}

			value = normalize(value);
		}

		// Construct unit quaternion_d from rigid-transformation matrix. The matrix must be orthonormal.
		public quaternion_d (double4x4 m) {
			double4 u = m.c0;
			double4 v = m.c1;
			double4 w = m.c2;

			if (u.x >= 0.0) {
				double t = v.y + w.z;
				if (t >= 0.0)
					value = double4(v.z - w.y, w.x - u.z, u.y - v.x, 1.0 + u.x + t);
				else
					value = double4(1.0 + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
			} else {
				double t = v.y - w.z;
				if (t >= 0.0)
					value = double4(u.y + v.x, 1.0 - u.x + t, v.z + w.y, w.x - u.z);
				else
					value = double4(w.x + u.z, v.z + w.y, 1.0 - u.x - t, u.y - v.x);
			}

			value = normalize(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d AxisAngle (double3 axis, double angle) {
			double s;
			double c;
			sincos(0.5 * angle, out s, out c);
			return quaternion_d(double4(axis * s, c));
		}

		public static quaternion_d EulerXYZ (double3 xyz) {
			double3 s;
			double3 c;
			sincos(0.5 * xyz, out s, out c);
			return quaternion_d(
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(-1.0, 1.0, -1.0, 1.0));
		}

		public static quaternion_d EulerXZY (double3 xyz) {
			double3 s;
			double3 c;
			sincos(0.5 * xyz, out s, out c);
			return quaternion_d(
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(1.0, 1.0, -1.0, -1.0));
		}

		public static quaternion_d EulerYXZ (double3 xyz) {
			double3 s;
			double3 c;
			sincos(0.5 * xyz, out s, out c);
			return quaternion_d(
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(-1.0, 1.0, 1.0, -1.0));
		}

		public static quaternion_d EulerYZX (double3 xyz) {
			double3 s;
			double3 c;
			sincos(0.5 * xyz, out s, out c);
			return quaternion_d(
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(-1.0, -1.0, 1.0, 1.0));
		}

		public static quaternion_d EulerZXY (double3 xyz) {
			double3 s;
			double3 c;
			sincos(0.5 * xyz, out s, out c);
			return quaternion_d(
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(1.0, -1.0, -1.0, 1.0));
		}

		public static quaternion_d EulerZYX (double3 xyz) {
			double3 s;
			double3 c;
			sincos(0.5 * xyz, out s, out c);
			return quaternion_d(
				double4(s.xyz, c.x) * c.yxxy * c.zzyz + s.yxxy * s.zzyz * double4(c.xyz, s.x) * double4(1.0, -1.0, 1.0, -1.0));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d EulerXYZ (double x, double y, double z) {
			return EulerXYZ(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d EulerXZY (double x, double y, double z) {
			return EulerXZY(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d EulerYXZ (double x, double y, double z) {
			return EulerYXZ(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d EulerYZX (double x, double y, double z) {
			return EulerYZX(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d EulerZXY (double x, double y, double z) {
			return EulerZXY(double3(x, y, z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d EulerZYX (double x, double y, double z) {
			return EulerZYX(double3(x, y, z));
		}

		public static quaternion_d Euler (double3 xyz, RotationOrder order = RotationOrder.ZXY) {
			switch (order) {
				case RotationOrder.XYZ:
					return EulerXYZ(xyz);
				case RotationOrder.XZY:
					return EulerXZY(xyz);
				case RotationOrder.YXZ:
					return EulerYXZ(xyz);
				case RotationOrder.YZX:
					return EulerYZX(xyz);
				case RotationOrder.ZXY:
					return EulerZXY(xyz);
				case RotationOrder.ZYX:
					return EulerZYX(xyz);
				default:
					return identity;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d Euler (double x, double y, double z, RotationOrder order = RotationOrder.ZXY) {
			return Euler(double3(x, y, z), order);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d RotateX (double angle) {
			double s;
			double c;
			sincos(0.5 * angle, out s, out c);
			return quaternion_d(s, 0.0, 0.0, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d RotateY (double angle) {
			double s;
			double c;
			sincos(0.5 * angle, out s, out c);
			return quaternion_d(0.0, s, 0.0, c);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d RotateZ (double angle) {
			double s;
			double c;
			sincos(0.5 * angle, out s, out c);
			return quaternion_d(0.0, 0.0, s, c);
		}

		public static quaternion_d LookRotation (double3 forward, double3 up) {
			double3 double3 = normalize(cross(up, forward));
			return quaternion_d(double3x3(double3, cross(forward, double3), forward));
		}

		public static quaternion_d LookRotationSafe (double3 forward, double3 up) {
			double x = dot(forward, forward);
			double num1 = dot(up, up);
			forward *= rsqrt(x);
			up *= rsqrt(num1);
			double3 double3_1 = cross(up, forward);
			double num2 = dot(double3_1, double3_1);
			double3 double3_2 = double3_1 * rsqrt(num2);
			bool c = min(min(x, num1), num2) > 1.00000001800251E-35 &&
			         max(max(x, num1), num2) < 1.00000004091848E+35 && (isfinite(x) && isfinite(num1)) &&
			         isfinite(num2);
			return quaternion_d(
				select(
					double4(0.0, 0.0, 0.0, 1.0),
					quaternion_d(double3x3(double3_2, cross(forward, double3_2), forward)).value,
					c));
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

		public bool Equals (quaternion_d other) {
			return value.Equals(other.value);
		}

		public override bool Equals (object obj) {
			if (ReferenceEquals(null, obj)) return false;
			return obj is quaternion_d && Equals((quaternion_d) obj);
		}

		public override int GetHashCode () {
			return 17 * (int)hash(this);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString () {
			return string.Format(
				"quaternion_d({0}f, {1}f, {2}f, {3}f)",
				value.x,
				value.y,
				value.z,
				value.w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string ToString (string format, IFormatProvider formatProvider) {
			return string.Format(
				"quaternion_d({0}f, {1}f, {2}f, {3}f)",
				value.x.ToString(format, formatProvider),
				value.y.ToString(format, formatProvider),
				value.z.ToString(format, formatProvider),
				value.w.ToString(format, formatProvider));
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
			return math.dot(a.value, b.value);
		}

		public static quaternion_d normalize (quaternion_d q) {
			double4 value = q.value;
			double len = dot(value, value);
			value = select(Mathematics.quaternion_d.identity.value, value * rsqrt(len), len > epsilon_normal);

			return quaternion_d(value);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static quaternion_d mul (quaternion_d a, quaternion_d b) {
			return quaternion_d(a.value.wwww * b.value + (a.value.xyzx * b.value.wwwx + a.value.yzxy * b.value.zxyy) * double4(1f, 1f, 1f, -1f) - a.value.zxyz * b.value.yzxz);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul (quaternion_d q, double3 v) {
			double3 y = 2.0 * cross(q.value.xyz, v);
			return v + q.value.w * y + cross(q.value.xyz, y);
		}

		public static quaternion_d nlerp (quaternion_d q1, quaternion_d q2, double t) {
			double dt = dot(q1, q2);
			if (dt < 0.0) {
				q2.value = -q2.value;
			}

			return normalize(quaternion_d(lerp(q1.value, q2.value, t)));
		}

		public static quaternion_d slerp (quaternion_d q1, quaternion_d q2, double t) {
			double dt = dot(q1, q2);
			if (dt < 0.0) {
				dt = -dt;
				q2.value = -q2.value;
			}

			if (dt < 0.9995) {
				double angle = acos(dt);
				double s = rsqrt(1.0 - dt * dt); // 1.0 / sin(angle)
				double w1 = sin(angle * (1.0 - t)) * s;
				double w2 = sin(angle * t) * s;
				return quaternion_d(q1.value * w1 + q2.value * w2);
			}

			// if the angle is small, use linear interpolation
			return nlerp(q1, q2, t);
		}

		public static double3 forward (quaternion_d q) {
			return mul(q, double3(0.0, 0.0, 1.0));
		}

		public static double3 up (quaternion_d q) {
			return mul(q, double3(0.0, 1.0, 0.0));
		}

		// get unit quaternion from rotation matrix
		// u, v, w must be ortho-normal.
		public static quaternion_d matrixToQuat (double3 u, double3 v, double3 w) {
			double4 q;
			if (u.x >= 0.0) {
				double t = v.y + w.z;
				if (t >= 0.0)
					q = new double4(v.z - w.y, w.x - u.z, u.y - v.x, 1.0 + u.x + t);
				else
					q = new double4(1.0 + u.x - t, u.y + v.x, w.x + u.z, v.z - w.y);
			} else {
				double t = v.y - w.z;
				if (t >= 0.0)
					q = new double4(u.y + v.x, 1.0 - u.x + t, v.z + w.y, w.x - u.z);
				else
					q = new double4(w.x + u.z, v.z + w.y, 1.0 - u.x - t, u.y - v.x);
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
