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
	}
}
