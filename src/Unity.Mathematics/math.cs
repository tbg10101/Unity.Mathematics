using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;

namespace Unity.Mathematics {
	public static partial class math_x {
		public const float pi = 3.14159265358979f;
		public const float infinity = float.PositiveInfinity;
		public const float negativeInfinity = float.NegativeInfinity;
		public const float deg2Rad = 0.01745329f;
		public const float rad2Deg = 57.29578f;
		private const float epsilon = 0.000001F;
		public const float epsilon_normal = 1e-30f;

		public const double pi_d = 3.14159265358979;
		public const double infinity_d = double.PositiveInfinity;
		public const double negativeInfinity_d = double.NegativeInfinity;
		public const double deg2Rad_d = 0.01745329;
		public const double rad2Deg_d = 57.29578;
		private const double epsilon_d = 0.000001;
		public const double epsilon_normal_d = 1e-30;

		// mul
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 mul (quaternion q, double3 v) {
			double3 t = 2.0 * cross(q.value.xyz, v);
			return v + q.value.w * t + cross(q.value.xyz, t);
		}

		// floorToInt
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int floorToInt (float x) {
			return (int) System.Math.Floor(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 floorToInt (float2 x) {
			return new int2((int) floor(x.x), (int) floor(x.y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 floorToInt (float3 x) {
			return new int3((int) floor(x.x), (int) floor(x.y), (int) floor(x.z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 floorToInt (float4 x) {
			return new int4((int) floor(x.x), (int) floor(x.y), (int) floor(x.z), (int) floor(x.w));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int floorToInt (double x) {
			return (int) System.Math.Floor(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 floorToInt (double2 x) {
			return new int2((int) floor(x.x), (int) floor(x.y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 floorToInt (double3 x) {
			return new int3((int) floor(x.x), (int) floor(x.y), (int) floor(x.z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 floorToInt (double4 x) {
			return new int4((int) floor(x.x), (int) floor(x.y), (int) floor(x.z), (int) floor(x.w));
		}

		// ceilToInt
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ceilToInt (float x) {
			return (int) System.Math.Ceiling(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int2 ceilToInt (float2 x) {
			return new int2((int) ceil(x.x), (int) ceil(x.y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 ceilToInt (float3 x) {
			return new int3((int) ceil(x.x), (int) ceil(x.y), (int) ceil(x.z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 ceilToInt (float4 x) {
			return new int4((int) ceil(x.x), (int) ceil(x.y), (int) ceil(x.z), (int) ceil(x.w));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int ceilToInt (double x) {
			return (int) System.Math.Ceiling(x);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 ceilToInt (double2 x) {
			return new int2((int) ceil(x.x), (int) ceil(x.y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int3 ceilToInt (double3 x) {
			return new int3((int) ceil(x.x), (int) ceil(x.y), (int) ceil(x.z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int4 ceilToInt (double4 x) {
			return new int4((int) ceil(x.x), (int) ceil(x.y), (int) ceil(x.z), (int) ceil(x.w));
		}

		// avg
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float avg (float pt1, float pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 avg (float2 pt1, float2 pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 avg (float3 pt1, float3 pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 avg (float4 pt1, float4 pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double avg (double pt1, double pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 avg (double2 pt1, double2 pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 avg (double3 pt1, double3 pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 avg (double4 pt1, double4 pt2) {
			return (pt1 + pt2) / 2.0f;
		}

		// approx
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool4 approx (double4 x, double4 y) {
			return new bool4(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z), approx(x.w, y.w));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool3 approx (double3 x, double3 y) {
			return new bool3(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool2 approx (double2 x, double2 y) {
			return new bool2(approx(x.x, y.x), approx(x.y, y.y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool approx (double x, double y) {
			return abs(x - y) < max(1E-06 * max(abs(x), abs(y)), 1.121039E-44);
		}

		// distancesq
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float distanceSquared (float3 pt1, float3 pt2) {
			return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double distanceSquared (double3 pt1, double3 pt2) {
			return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z;
		}

		// inverse
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 inverse (float2 v) {
			return new float2 {
				x = 1.0f / v.x,
				y = 1.0f / v.y
			};
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 inverse (float3 v) {
			return new float3 {
				x = 1.0f / v.x,
				y = 1.0f / v.y,
				z = 1.0f / v.z
			};
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 inverse (float4 v) {
			return new float4 {
				x = 1.0f / v.x,
				y = 1.0f / v.y,
				z = 1.0f / v.z,
				w = 1.0f / v.w
			};
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 inverse (double2 v) {
			return new double2 {
				x = 1.0 / v.x,
				y = 1.0 / v.y
			};
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 inverse (double3 v) {
			return new double3 {
				x = 1.0 / v.x,
				y = 1.0 / v.y,
				z = 1.0 / v.z
			};
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 inverse (double4 v) {
			return new double4 {
				x = 1.0 / v.x,
				y = 1.0 / v.y,
				z = 1.0 / v.z,
				w = 1.0 / v.w
			};
		}

		// intersects
		public static bool intersects (ray r, bounds box) {
			float3 dirfrac = inverse(r.direction);

			float t1 = (box.min.x - r.origin.x) * dirfrac.x;
			float t2 = (box.max.x - r.origin.x) * dirfrac.x;
			float t3 = (box.min.y - r.origin.y) * dirfrac.y;
			float t4 = (box.max.y - r.origin.y) * dirfrac.y;
			float t5 = (box.min.z - r.origin.z) * dirfrac.z;
			float t6 = (box.max.z - r.origin.z) * dirfrac.z;

			float tmin = max(max(min(t1, t2), min(t3, t4)), min(t5, t6));
			float tmax = min(min(max(t1, t2), max(t3, t4)), max(t5, t6));

			// if tmax < 0, ray (line) is intersecting AABB, but whole AABB is behind us
			if (tmax < 0) {
				return false;
			}

			// if tmin <= tmax, ray intersects AABB
			return tmin <= tmax;
		}

		public static bool intersects (ray_d r, bounds_d box) {
			double3 dirfrac = inverse(r.direction);

			double t1 = (box.min.x - r.origin.x) * dirfrac.x;
			double t2 = (box.max.x - r.origin.x) * dirfrac.x;
			double t3 = (box.min.y - r.origin.y) * dirfrac.y;
			double t4 = (box.max.y - r.origin.y) * dirfrac.y;
			double t5 = (box.min.z - r.origin.z) * dirfrac.z;
			double t6 = (box.max.z - r.origin.z) * dirfrac.z;

			double tmin = max(max(min(t1, t2), min(t3, t4)), min(t5, t6));
			double tmax = min(min(max(t1, t2), max(t3, t4)), max(t5, t6));

			// if tmax < 0, ray (line) is intersecting AABB, but whole AABB is behind us
			if (tmax < 0) {
				return false;
			}

			// if tmin <= tmax, ray intersects AABB
			return tmin <= tmax;
		}

		public static bool intersects2 (ray r, bounds box) {
			float3 invRayDir = inverse(r.direction);

			float3 t0 = (box.max - r.origin) * invRayDir;
			float3 t1 = (box.min - r.origin) * invRayDir;
			float3 tmin = min(t0, t1);
			float3 tmax = max(t0, t1);

			return cmax(tmin) <= cmin(tmax);
		}

		public static bool intersects2 (ray_d r, bounds_d box) {
			double3 invRayDir = inverse(r.direction);

			double3 t0 = (box.max - r.origin) * invRayDir;
			double3 t1 = (box.min - r.origin) * invRayDir;
			double3 tmin = min(t0, t1);
			double3 tmax = max(t0, t1);

			return cmax(tmin) <= cmin(tmax);
		}

		public static bool intersectsLines (double2 l0p0, double2 l0p1, double2 l1p0, double2 l1p1, ref double2 result) {
			double num1 = l0p1.x - l0p0.x;
			double num2 = l0p1.y - l0p0.y;
			double num3 = l1p1.x - l1p0.x;
			double num4 = l1p1.y - l1p0.y;
			double num5 = num1 * num4 - num2 * num3;
			if (num5 == 0.0)
				return false;
			double num6 = l1p0.x - l0p0.x;
			double num7 = l1p0.y - l0p0.y;
			double num8 = (num6 * num4 - num7 * num3) / num5;
			result = new double2(l0p0.x + num8 * num1, l0p0.y + num8 * num2);
			return true;
		}

		internal static bool intersectsSegments (double2 l0p0, double2 l0p1, double2 l1p0, double2 l1p1, ref double2 result) {
			double num1 = l0p1.x - l0p0.x;
			double num2 = l0p1.y - l0p0.y;
			double num3 = l1p1.x - l1p0.x;
			double num4 = l1p1.y - l1p0.y;
			double num5 = (num1 * num4 - num2 * num3);
			if (num5 == 0.0)
				return false;
			double num6 = l1p0.x - l0p0.x;
			double num7 = l1p0.y - l0p0.y;
			double num8 = (num6 * num4 - num7 * num3) / num5;
			if (num8 < 0.0 || num8 > 1.0)
				return false;
			double num9 = (num6 * num2 - num7 * num1) / num5;
			if (num9 < 0.0 || num9 > 1.0)
				return false;
			result = new double2(l0p0.x + num8 * num1, l0p0.y + num8 * num2);
			return true;
		}

		// fast rsqrt https://en.wikipedia.org/wiki/Fast_inverse_square_root
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float frsqrt (float a) {
			IntFloatUnion u;
			u.intValue = 0;
			float ahalf = 0.5f * a;
			u.floatValue = a;
			u.intValue = 0x5f375a86 - (u.intValue >> 1);
			u.floatValue = u.floatValue * 1 / 5f - ahalf * u.floatValue * u.floatValue;
			return u.floatValue * a;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 frsqrt (float2 a) {
			return new float2(frsqrt(a.x), frsqrt(a.y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 frsqrt (float3 a) {
			return new float3(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 frsqrt (float4 a) {
			return new float4(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z), frsqrt(a.w));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double frsqrt (double a) {
			LongDoubleUnion u;
			u.longValue = 0;
			double ahalf = 0.5f * a;
			u.doubleValue = a;
			u.longValue = 0x5fe6eb50c7b537a9 - (u.longValue >> 1);
			u.doubleValue = u.doubleValue * 1 / 5f - ahalf * u.doubleValue * u.doubleValue;
			return u.doubleValue * a;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 frsqrt (double2 a) {
			return new double2(frsqrt(a.x), frsqrt(a.y));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 frsqrt (double3 a) {
			return new double3(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 frsqrt (double4 a) {
			return new double4(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z), frsqrt(a.w));
		}

		// http://geomalgorithms.com/a07-_distance.html#dist3D_Segment_to_Segment()
		// you an test distance to a point by setting the first two parameters to the same vector (it doesn't work if the second pair of coordinates
		// are the same)
		public static double3[] closestPointsOnSegments (double3 line1p0, double3 line1p1, double3 line2p0, double3 line2p1) {
			const double smallNumber = 0.00000001;

			if (line1p0.Equals(line1p1) && line2p0.Equals(line2p1)) {
				return new[] {line1p0, line2p0};
			}

			double3 u = line1p1 - line1p0;
			double3 v = line2p1 - line2p0;
			double3 w = line1p0 - line2p0;

			double a = math.dot(u, u); // always >= 0
			double b = math.dot(u, v);
			double c = math.dot(v, v); // always >= 0
			double d = math.dot(u, w);
			double e = math.dot(v, w);

			double D = a * c - b * b; // always >= 0

			double sN, sD = D; // sc = sN / sD, default sD = D >= 0
			double tN, tD = D; // tc = tN / tD, default tD = D >= 0

			// compute the line parameters of the two closest points
			if (D < smallNumber) { // the lines are almost parallel
				sN = 0.0; // force using point P0 on segment S1
				sD = 1.0; // to prevent possible division by 0.0 later
				tN = e;
				tD = c;
			} else { // get the closest points on the infinite lines
				sN = (b * e - c * d);
				tN = (a * e - b * d);

				if (sN < 0.0) { // sc < 0 => the s=0 edge is visible
					sN = 0.0;
					tN = e;
					tD = c;
				} else if (sN > sD) { // sc > 1  => the s=1 edge is visible
					sN = sD;
					tN = e + b;
					tD = c;
				}
			}

			if (tN < 0.0) { // tc < 0 => the t=0 edge is visible
				tN = 0.0;

				// recompute sc for this edge
				if (-d < 0.0) {
					sN = 0.0;
				} else if (-d > a) {
					sN = sD;
				} else {
					sN = -d;
					sD = a;
				}
			} else if (tN > tD) { // tc > 1  => the t=1 edge is visible
				tN = tD;

				// recompute sc for this edge
				if ((-d + b) < 0.0) {
					sN = 0.0;
				} else if ((-d + b) > a) {
					sN = sD;
				} else {
					sN = (-d + b);
					sD = a;
				}
			}

			// finally do the division to get sc and tc
			var sc = (abs(sN) < smallNumber ? 0.0 : sN / sD);
			var tc = (abs(tN) < smallNumber ? 0.0 : tN / tD);

			return new[] {
				line1p0 + sc * u,
				line2p0 + tc * v
			};
		}

		public static double closestSegmentToSegmentDistance (double3 line1p0, double3 line1p1, double3 line2p0, double3 line2p1) {
			double3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
			return distance(points[0], points[1]);
		}

		public static double closestSegmentToSegmentSqrDistance (double3 line1p0, double3 line1p1, double3 line2p0, double3 line2p1) {
			double3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
			return distanceSquared(points[0], points[1]);
		}

		public static double3 closestSegmentToSegmentMidPoint (double3 line1p0, double3 line1p1, double3 line2p0, double3 line2p1) {
			double3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
			return (points[0] + points[1]) / 2.0;
		}

		public static float3[] closestPointsOnSegments (float3 line1p0, float3 line1p1, float3 line2p0, float3 line2p1) {
			if (line1p0.Equals(line1p1) && line2p0.Equals(line2p1)) {
				return new[] {line1p0, line2p0};
			}

			float3 u = line1p1 - line1p0;
			float3 v = line2p1 - line2p0;
			float3 w = line1p0 - line2p0;

			float a = math.dot(u, u); // always >= 0
			float b = math.dot(u, v);
			float c = math.dot(v, v); // always >= 0
			float d = math.dot(u, w);
			float e = math.dot(v, w);

			float D = a * c - b * b; // always >= 0

			float sN, sD = D; // sc = sN / sD, default sD = D >= 0
			float tN, tD = D; // tc = tN / tD, default tD = D >= 0

			// compute the line parameters of the two closest points
			if (D < epsilon) { // the lines are almost parallel
				sN = 0.0f; // force using point P0 on segment S1
				sD = 1.0f; // to prevent possible division by 0.0 later
				tN = e;
				tD = c;
			} else { // get the closest points on the infinite lines
				sN = (b * e - c * d);
				tN = (a * e - b * d);

				if (sN < 0.0f) { // sc < 0 => the s=0 edge is visible
					sN = 0.0f;
					tN = e;
					tD = c;
				} else if (sN > sD) { // sc > 1  => the s=1 edge is visible
					sN = sD;
					tN = e + b;
					tD = c;
				}
			}

			if (tN < 0.0f) { // tc < 0 => the t=0 edge is visible
				tN = 0.0f;

				// recompute sc for this edge
				if (-d < 0.0f) {
					sN = 0.0f;
				} else if (-d > a) {
					sN = sD;
				} else {
					sN = -d;
					sD = a;
				}
			} else if (tN > tD) { // tc > 1  => the t=1 edge is visible
				tN = tD;

				// recompute sc for this edge
				if ((-d + b) < 0.0f) {
					sN = 0.0f;
				} else if ((-d + b) > a) {
					sN = sD;
				} else {
					sN = (-d + b);
					sD = a;
				}
			}

			// finally do the division to get sc and tc
			var sc = (abs(sN) < epsilon ? 0.0f : sN / sD);
			var tc = (abs(tN) < epsilon ? 0.0f : tN / tD);

			return new[] {
				line1p0 + sc * u,
				line2p0 + tc * v
			};
		}

		public static float closestSegmentToSegmentDistance (float3 line1p0, float3 line1p1, float3 line2p0, float3 line2p1) {
			float3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
			return distance(points[0], points[1]);
		}

		public static float closestSegmentToSegmentSqrDistance (float3 line1p0, float3 line1p1, float3 line2p0, float3 line2p1) {
			float3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
			return distanceSquared(points[0], points[1]);
		}

		public static float3 closestSegmentToSegmentMidPoint (float3 line1p0, float3 line1p1, float3 line2p0, float3 line2p1) {
			float3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
			return avg(points[0], points[1]);
		}

		public static float4 toFloat4 (this Color c) {
			return new float4(c.r, c.g, c.b, c.a);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float normalizeAngle (float angle) {
			float a = angle % 360.0f;
			return a >= 0.0f ? a : (a + 360.0f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double normalizeAngle (double angle) {
			double a = angle % 360.0;
			return a >= 0.0 ? a : (a + 360.0);
		}

		public static Quaternion toQuaternion (this quaternion q) {
			return q;
		}

		public static Quaternion toNormalizedQuaternion (this quaternion q) {
			return q.toQuaternion().normalized;
		}
	}
}
