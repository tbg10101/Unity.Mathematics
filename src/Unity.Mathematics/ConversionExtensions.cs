using System.Runtime.CompilerServices;
using UnityEngine;
using static Unity.Mathematics.math;

namespace Unity.Mathematics {
	public static class ConversionExtensions {
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 toFloat2(this double2 d) {
			return float2((float)d.x, (float)d.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 toFloat3(this double3 d) {
			return float3((float)d.x, (float)d.y, (float)d.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 toFloat4(this double4 d) {
			return float4((float)d.x, (float)d.y, (float)d.z, (float)d.w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 toDouble2(this float2 f) {
			return double2(f.x, f.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 toDouble3(this float3 f) {
			return double3(f.x, f.y, f.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 toDouble4(this float4 f) {
			return double4(f.x, f.y, f.z, f.w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float2 toFloat2(this Vector2 f) {
			return float2(f.x, f.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float3 toFloat3(this Vector3 f) {
			return float3(f.x, f.y, f.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float4 toFloat4(this Vector4 f) {
			return float4(f.x, f.y, f.z, f.w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double2 toDouble2(this Vector2 f) {
			return double2(f.x, f.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double3 toDouble3(this Vector3 f) {
			return double3(f.x, f.y, f.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double4 toDouble4(this Vector4 f) {
			return double4(f.x, f.y, f.z, f.w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 toVector2 (this float2 d) {
			return new Vector2(d.x, d.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 toVector3 (this float3 d) {
			return new Vector3(d.x, d.y, d.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 toVector4 (this float4 d) {
			return new Vector4(d.x, d.y, d.z, d.w);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector2 toVector2 (this double2 d) {
			return new Vector2((float)d.x, (float)d.y);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector3 toVector3 (this double3 d) {
			return new Vector3((float)d.x, (float)d.y, (float)d.z);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Vector4 toVector4 (this double4 d) {
			return new Vector4((float)d.x, (float)d.y, (float)d.z, (float)d.w);
		}
	}
}
