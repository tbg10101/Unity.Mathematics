using UnityEngine;
using static Unity.Mathematics.math;

namespace Unity.Mathematics {
	public static class ConversionExtensions {
		public static float2 toFloat2(this double2 d) {
			return float2((float)d.x, (float)d.y);
		}

		public static float3 toFloat3(this double3 d) {
			return float3((float)d.x, (float)d.y, (float)d.z);
		}

		public static float4 toFloat4(this double4 d) {
			return float4((float)d.x, (float)d.y, (float)d.z, (float)d.w);
		}

		public static double2 toDouble2(this float2 f) {
			return double2(f.x, f.y);
		}

		public static double3 toDouble3(this float3 f) {
			return double3(f.x, f.y, f.z);
		}

		public static double4 toDouble4(this float4 f) {
			return double4(f.x, f.y, f.z, f.w);
		}

		public static double2 toDouble2(this Vector2 f) {
			return double2(f.x, f.y);
		}

		public static double3 toDouble3(this Vector3 f) {
			return double3(f.x, f.y, f.z);
		}

		public static double4 toDouble4(this Vector4 f) {
			return double4(f.x, f.y, f.z, f.w);
		}

		public static Vector2 toVector2 (this double2 d) {
			return new Vector2((float)d.x, (float)d.y);
		}

		public static Vector3 toVector3 (this double3 d) {
			return new Vector3((float)d.x, (float)d.y, (float)d.z);
		}

		public static Vector4 toVector4 (this double4 d) {
			return new Vector4((float)d.x, (float)d.y, (float)d.z, (float)d.w);
		}
	}
}
