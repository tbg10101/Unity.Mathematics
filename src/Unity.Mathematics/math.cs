// * TODO: Validate -1 vs 1 behaviour in math lib. eg < returns 0 / -1
//   Check if all operators act accordingly
// * Also int3 etc bool casts? should they exist?
// * Should we allow float4 value = 5; it is convenient and how it is in hlsl but maybe not the right fit in C#?

using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    public static partial class math
    {
        public const float pi = 3.14159265358979f;
        public const float infinity = float.PositiveInfinity;
        public const float negativeInfinity = float.NegativeInfinity;
        public const float deg2Rad = 0.01745329f;
        public const float rad2Deg = 57.29578f;

        public const double pi_d = 3.14159265358979;
        public const double infinity_d = double.PositiveInfinity;
        public const double negativeInfinity_d = double.NegativeInfinity;
        public const double deg2Rad_d = 0.01745329;
        public const double rad2Deg_d = 57.29578;

        // min
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float min(float a, float b) { return float.IsNaN(b) || a < b ? a : b; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 min(float2 a, float2 b) { return new float2(min(a.x, b.x), min(a.y, b.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 min(float3 a, float3 b) { return new float3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 min(float4 a, float4 b) { return new float4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w)); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int min(int a, int b) { return a < b ? a : b; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int2 min(int2 a, int2 b) { return new int2(min(a.x, b.x), min(a.y, b.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int3 min(int3 a, int3 b) { return new int3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int4 min(int4 a, int4 b) { return new int4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w)); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double min(double a, double b) { return double.IsNaN(b) || a < b ? a : b; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 min(double2 a, double2 b) { return new double2(min(a.x, b.x), min(a.y, b.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 min(double3 a, double3 b) { return new double3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 min(double4 a, double4 b) { return new double4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w)); }

        // max
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float max(float a, float b) { return float.IsNaN(b) || a > b ? a : b; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 max(float2 a, float2 b) { return new float2(max(a.x, b.x), max(a.y, b.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 max(float3 a, float3 b) { return new float3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 max(float4 a, float4 b) { return new float4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w)); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int max(int a, int b) { return a > b ? a : b; } // Use Math.Max as it is handling properly NaN
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int2 max(int2 a, int2 b) { return new int2(max(a.x, b.x), max(a.y, b.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int3 max(int3 a, int3 b) { return new int3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int4 max(int4 a, int4 b) { return new int4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w)); }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double max(double a, double b) { return double.IsNaN(b) || a > b ? a : b; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 max(double2 a, double2 b) { return new double2(max(a.x, b.x), max(a.y, b.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 max(double3 a, double3 b) { return new double3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 max(double4 a, double4 b) { return new double4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w)); }

        // lerp
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float lerp(float a, float b, float w) { return a + w * (b - a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 lerp(float2 a, float2 b, float w) { return a + w * (b - a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 lerp(float3 a, float3 b, float w) { return a + w * (b - a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 lerp(float4 a, float4 b, float w) { return a + w * (b - a); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double lerp(double a, double b, double w) { return a + w * (b - a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 lerp(double2 a, double2 b, double w) { return a + w * (b - a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 lerp(double3 a, double3 b, double w) { return a + w * (b - a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 lerp(double4 a, double4 b, double w) { return a + w * (b - a); }

        // mad
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float mad(float a, float b, float c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 mad(float2 a, float2 b, float2 c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 mad(float3 a, float3 b, float3 c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 mad(float4 a, float4 b, float4 c) { return a * b + c; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int mad(int a, int b, int c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int2 mad(int2 a, int2 b, int2 c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int3 mad(int3 a, int3 b, int3 c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int4 mad(int4 a, int4 b, int4 c) { return a * b + c; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double mad(double a, double b, double c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 mad(double2 a, double2 b, double2 c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 mad(double3 a, double3 b, double3 c) { return a * b + c; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 mad(double4 a, double4 b, double4 c) { return a * b + c; }

        // TODO: madint version????


        // clamp
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float clamp(float x, float a, float b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 clamp(float2 x, float2 a, float2 b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 clamp(float3 x, float3 a, float3 b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 clamp(float4 x, float4 a, float4 b) { return max(a, min(b, x)); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int clamp(int x, int a, int b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int2 clamp(int2 x, int2 a, int2 b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int3 clamp(int3 x, int3 a, int3 b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int4 clamp(int4 x, int4 a, int4 b) { return max(a, min(b, x)); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double clamp(double x, double a, double b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 clamp(double2 x, double2 a, double2 b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 clamp(double3 x, double3 a, double3 b) { return max(a, min(b, x)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 clamp(double4 x, double4 a, double4 b) { return max(a, min(b, x)); }

        // saturate
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float saturate(float x) { return clamp(x, 0.0f, 1.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 saturate(float2 x) { return clamp(x, new float2(0.0f), new float2(1.0f)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 saturate(float3 x) { return clamp(x, new float3(0.0f), new float3(1.0f)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 saturate(float4 x) { return clamp(x, new float4(0.0f), new float4(1.0f)); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double saturate(double x) { return clamp(x, 0.0, 1.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 saturate(double2 x) { return clamp(x, new double2(0.0), new double2(1.0)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 saturate(double3 x) { return clamp(x, new double3(0.0), new double3(1.0)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 saturate(double4 x) { return clamp(x, new double4(0.0), new double4(1.0)); }

        // abs
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float abs(float a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int abs(int a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double abs(double a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 abs(float2 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 abs(float3 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 abs(float4 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int2 abs(int2 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int3 abs(int3 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int4 abs(int4 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 abs(double2 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 abs(double3 a) { return max(-a, a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 abs(double4 a) { return max(-a, a); }

        // dot
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float dot(float pt1, float pt2) { return pt1 * pt2; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float dot(float2 pt1, float2 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float dot(float3 pt1, float3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float dot(float4 pt1, float4 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z + pt1.w * pt2.w; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double dot(double pt1, double pt2) { return pt1 * pt2; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double dot(double2 pt1, double2 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double dot(double3 pt1, double3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double dot(double4 pt1, double4 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z + pt1.w * pt2.w; }

        // dot
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float avg(float pt1, float pt2) { return (pt1 + pt2) / 2.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 avg(float2 pt1, float2 pt2) { return (pt1 + pt2) / 2.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 avg(float3 pt1, float3 pt2) { return (pt1 + pt2) / 2.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 avg(float4 pt1, float4 pt2) { return (pt1 + pt2) / 2.0f; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double avg(double pt1, double pt2) { return (pt1 + pt2) / 2.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 avg(double2 pt1, double2 pt2) { return (pt1 + pt2) / 2.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 avg(double3 pt1, double3 pt2) { return (pt1 + pt2) / 2.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 avg(double4 pt1, double4 pt2) { return (pt1 + pt2) / 2.0f; }

        // tan
        public static float tan(float value) { return (float)System.Math.Tan(value); }
        public static float2 tan(float2 value) { return new float2(tan(value.x), tan(value.y)); }
        public static float3 tan(float3 value) { return new float3(tan(value.x), tan(value.y), tan(value.z)); }
        public static float4 tan(float4 value) { return new float4(tan(value.x), tan(value.y), tan(value.z), tan(value.w)); }

        public static double tan(double value) { return System.Math.Tan(value); }
        public static double2 tan(double2 value) { return new double2(tan(value.x), tan(value.y)); }
        public static double3 tan(double3 value) { return new double3(tan(value.x), tan(value.y), tan(value.z)); }
        public static double4 tan(double4 value) { return new double4(tan(value.x), tan(value.y), tan(value.z), tan(value.w)); }

        // atan
        public static float atan(float value) { return (float)System.Math.Atan(value); }
        public static float2 atan(float2 value) { return new float2(atan(value.x), atan(value.y)); }
        public static float3 atan(float3 value) { return new float3(atan(value.x), atan(value.y), atan(value.z)); }
        public static float4 atan(float4 value) { return new float4(atan(value.x), atan(value.y), atan(value.z), atan(value.w)); }

        public static double atan(double value) { return System.Math.Atan(value); }
        public static double2 atan(double2 value) { return new double2(atan(value.x), atan(value.y)); }
        public static double3 atan(double3 value) { return new double3(atan(value.x), atan(value.y), atan(value.z)); }
        public static double4 atan(double4 value) { return new double4(atan(value.x), atan(value.y), atan(value.z), atan(value.w)); }

        // atan2
        public static float atan2(float pt1, float pt2) { return (float)System.Math.Atan2(pt1, pt2); }
        public static float2 atan2(float2 pt1, float2 pt2) { return new float2(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y)); }
        public static float3 atan2(float3 pt1, float3 pt2) { return new float3(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z)); }
        public static float4 atan2(float4 pt1, float4 pt2) { return new float4(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z), atan2(pt1.w, pt2.w)); }

        public static double atan2(double pt1, double pt2) { return System.Math.Atan2(pt1, pt2); }
        public static double2 atan2(double2 pt1, double2 pt2) { return new double2(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y)); }
        public static double3 atan2(double3 pt1, double3 pt2) { return new double3(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z)); }
        public static double4 atan2(double4 pt1, double4 pt2) { return new double4(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z), atan2(pt1.w, pt2.w)); }

        // cos
        public static float cos(float a) { return (float)System.Math.Cos((float)a); }
        public static float2 cos(float2 a) { return new float2(cos(a.x), cos(a.y)); }
        public static float3 cos(float3 a) { return new float3(cos(a.x), cos(a.y), cos(a.z)); }
        public static float4 cos(float4 a) { return new float4(cos(a.x), cos(a.y), cos(a.z), cos(a.w)); }

        public static double cos(double a) { return System.Math.Cos((double)a); }
        public static double2 cos(double2 a) { return new double2(cos(a.x), cos(a.y)); }
        public static double3 cos(double3 a) { return new double3(cos(a.x), cos(a.y), cos(a.z)); }
        public static double4 cos(double4 a) { return new double4(cos(a.x), cos(a.y), cos(a.z), cos(a.w)); }

        // acos
        public static float acos(float a) { return (float)System.Math.Acos((float)a); }
        public static float2 acos(float2 a) { return new float2(acos(a.x), acos(a.y)); }
        public static float3 acos(float3 a) { return new float3(acos(a.x), acos(a.y), acos(a.z)); }
        public static float4 acos(float4 a) { return new float4(acos(a.x), acos(a.y), acos(a.z), acos(a.w)); }

        public static double acos(double a) { return (double)System.Math.Acos((double)a); }
        public static double2 acos(double2 a) { return new double2(acos(a.x), acos(a.y)); }
        public static double3 acos(double3 a) { return new double3(acos(a.x), acos(a.y), acos(a.z)); }
        public static double4 acos(double4 a) { return new double4(acos(a.x), acos(a.y), acos(a.z), acos(a.w)); }

        // sin
        public static float sin(float a) { return (float)System.Math.Sin((float)a); }
        public static float2 sin(float2 a) { return new float2(sin(a.x), sin(a.y)); }
        public static float3 sin(float3 a) { return new float3(sin(a.x), sin(a.y), sin(a.z)); }
        public static float4 sin(float4 a) { return new float4(sin(a.x), sin(a.y), sin(a.z), sin(a.w)); }

        public static double sin(double a) { return (double)System.Math.Sin((double)a); }
        public static double2 sin(double2 a) { return new double2(sin(a.x), sin(a.y)); }
        public static double3 sin(double3 a) { return new double3(sin(a.x), sin(a.y), sin(a.z)); }
        public static double4 sin(double4 a) { return new double4(sin(a.x), sin(a.y), sin(a.z), sin(a.w)); }

        // asin
        public static float asin(float a) { return (float)System.Math.Asin((float)a); }
        public static float2 asin(float2 a) { return new float2(asin(a.x), asin(a.y)); }
        public static float3 asin(float3 a) { return new float3(asin(a.x), asin(a.y), asin(a.z)); }
        public static float4 asin(float4 a) { return new float4(asin(a.x), asin(a.y), asin(a.z), asin(a.w)); }

        public static double asin(double a) { return (double)System.Math.Asin((double)a); }
        public static double2 asin(double2 a) { return new double2(asin(a.x), asin(a.y)); }
        public static double3 asin(double3 a) { return new double3(asin(a.x), asin(a.y), asin(a.z)); }
        public static double4 asin(double4 a) { return new double4(asin(a.x), asin(a.y), asin(a.z), asin(a.w)); }

        // floor
        public static float floor(float a) { return (float)System.Math.Floor((float)a); }
        public static float2 floor(float2 a) { return new float2(floor(a.x), floor(a.y)); }
        public static float3 floor(float3 a) { return new float3(floor(a.x), floor(a.y), floor(a.z)); }
        public static float4 floor(float4 a) { return new float4(floor(a.x), floor(a.y), floor(a.z), floor(a.w)); }

        public static double floor(double a) { return (double)System.Math.Floor((double)a); }
        public static double2 floor(double2 a) { return new double2(floor(a.x), floor(a.y)); }
        public static double3 floor(double3 a) { return new double3(floor(a.x), floor(a.y), floor(a.z)); }
        public static double4 floor(double4 a) { return new double4(floor(a.x), floor(a.y), floor(a.z), floor(a.w)); }

        // ceil
        public static float ceil(float a) { return (float)System.Math.Ceiling((float)a); }
        public static float2 ceil(float2 a) { return new float2(ceil(a.x), ceil(a.y)); }
        public static float3 ceil(float3 a) { return new float3(ceil(a.x), ceil(a.y), ceil(a.z)); }
        public static float4 ceil(float4 a) { return new float4(ceil(a.x), ceil(a.y), ceil(a.z), ceil(a.w)); }

        public static double ceil(double a) { return (double)System.Math.Ceiling((double)a); }
        public static double2 ceil(double2 a) { return new double2(ceil(a.x), ceil(a.y)); }
        public static double3 ceil(double3 a) { return new double3(ceil(a.x), ceil(a.y), ceil(a.z)); }
        public static double4 ceil(double4 a) { return new double4(ceil(a.x), ceil(a.y), ceil(a.z), ceil(a.w)); }

        // round
        public static float round(float a) { return (float)System.Math.Round((float)a); }
        public static float2 round(float2 a) { return new float2(round(a.x), round(a.y)); }
        public static float3 round(float3 a) { return new float3(round(a.x), round(a.y), round(a.z)); }
        public static float4 round(float4 a) { return new float4(round(a.x), round(a.y), round(a.z), round(a.w)); }

        public static double round(double a) { return (double)System.Math.Round((double)a); }
        public static double2 round(double2 a) { return new double2(round(a.x), round(a.y)); }
        public static double3 round(double3 a) { return new double3(round(a.x), round(a.y), round(a.z)); }
        public static double4 round(double4 a) { return new double4(round(a.x), round(a.y), round(a.z), round(a.w)); }

        // frac
        public static float frac(float a) { return a - floor(a); }
        public static float2 frac(float2 a) { return a - floor(a); }
        public static float3 frac(float3 a) { return a - floor(a); }
        public static float4 frac(float4 a) { return a - floor(a); }

        public static double frac(double a) { return a - floor(a); }
        public static double2 frac(double2 a) { return a - floor(a); }
        public static double3 frac(double3 a) { return a - floor(a); }
        public static double4 frac(double4 a) { return a - floor(a); }

        // rcp
        public static float rcp(float a) { return 1f / a; }
        public static float2 rcp(float2 a) { return 1f / a; }
        public static float3 rcp(float3 a) { return 1f / a; }
        public static float4 rcp(float4 a) { return 1f / a; }

        public static double rcp(double a) { return 1f / a; }
        public static double2 rcp(double2 a) { return 1f / a; }
        public static double3 rcp(double3 a) { return 1f / a; }
        public static double4 rcp(double4 a) { return 1f / a; }

        // sign
        public static float sign(float f) { return f == 0f ? 0f : (f > 0f ? 1f : 0.0f) - (f < 0f ? 1.0f : 0.0f); }
        public static float2 sign(float2 f) { return new float2(sign(f.x), sign(f.y)); }
        public static float3 sign(float3 f) { return new float3(sign(f.x), sign(f.y), sign(f.z)); }
        public static float4 sign(float4 f) { return new float4(sign(f.x), sign(f.y), sign(f.z), sign(f.w)); }

        public static double sign(double f) { return f == 0f ? 0f : (f > 0f ? 1f : 0.0) - (f < 0f ? 1.0 : 0.0); }
        public static double2 sign(double2 f) { return new double2(sign(f.x), sign(f.y)); }
        public static double3 sign(double3 f) { return new double3(sign(f.x), sign(f.y), sign(f.z)); }
        public static double4 sign(double4 f) { return new double4(sign(f.x), sign(f.y), sign(f.z), sign(f.w)); }

        // mix
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float mix(float a, float b, float x) { return x * (b - a) + a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 mix(float2 a, float2 b, float2 x) { return x * (b - a) + a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 mix(float3 a, float3 b, float3 x) { return x * (b - a) + a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 mix(float4 a, float4 b, float4 x) { return x * (b - a) + a; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double mix(double a, double b, double x) { return x * (b - a) + a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 mix(double2 a, double2 b, double2 x) { return x * (b - a) + a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 mix(double3 a, double3 b, double3 x) { return x * (b - a) + a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 mix(double4 a, double4 b, double4 x) { return x * (b - a) + a; }

        // pow
        public static float pow(float a, float b) { return (float)System.Math.Pow((float)a, (float)b); }
        public static float2 pow(float2 a, float2 b) { return new float2(pow(a.x, b.x), pow(a.y, b.y)); }
        public static float3 pow(float3 a, float3 b) { return new float3(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z)); }
        public static float4 pow(float4 a, float4 b) { return new float4(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z), pow(a.w, b.w)); }

        public static double pow(double a, double b) { return (double)System.Math.Pow((double)a, (double)b); }
        public static double2 pow(double2 a, double2 b) { return new double2(pow(a.x, b.x), pow(a.y, b.y)); }
        public static double3 pow(double3 a, double3 b) { return new double3(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z)); }
        public static double4 pow(double4 a, double4 b) { return new double4(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z), pow(a.w, b.w)); }

        // powr - assumes sign of a is 0 or greater
        public static float powr(float a, float b) { return pow(a, b); }
        public static float2 powr(float2 a, float2 b) { return pow(a, b); }
        public static float3 powr(float3 a, float3 b) { return pow(a, b); }
        public static float4 powr(float4 a, float4 b) { return pow(a, b); }

        public static double powr(double a, double b) { return pow(a, b); }
        public static double2 powr(double2 a, double2 b) { return pow(a, b); }
        public static double3 powr(double3 a, double3 b) { return pow(a, b); }
        public static double4 powr(double4 a, double4 b) { return pow(a, b); }

        // exp
        public static float exp(float x) { return (float)System.Math.Exp((float)x); }
        public static float2 exp(float2 a) { return new float2(exp(a.x), exp(a.y)); }
        public static float3 exp(float3 a) { return new float3(exp(a.x), exp(a.y), exp(a.z)); }
        public static float4 exp(float4 a) { return new float4(exp(a.x), exp(a.y), exp(a.z), exp(a.w)); }

        public static double exp(double x) { return (double)System.Math.Exp((double)x); }
        public static double2 exp(double2 a) { return new double2(exp(a.x), exp(a.y)); }
        public static double3 exp(double3 a) { return new double3(exp(a.x), exp(a.y), exp(a.z)); }
        public static double4 exp(double4 a) { return new double4(exp(a.x), exp(a.y), exp(a.z), exp(a.w)); }

        // log
        public static float log(float x) { return (float)System.Math.Log((float)x); }
        public static float2 log(float2 a) { return new float2(log(a.x), log(a.y)); }
        public static float3 log(float3 a) { return new float3(log(a.x), log(a.y), log(a.z)); }
        public static float4 log(float4 a) { return new float4(log(a.x), log(a.y), log(a.z), log(a.w)); }

        public static double log(double x) { return (double)System.Math.Log((double)x); }
        public static double2 log(double2 a) { return new double2(log(a.x), log(a.y)); }
        public static double3 log(double3 a) { return new double3(log(a.x), log(a.y), log(a.z)); }
        public static double4 log(double4 a) { return new double4(log(a.x), log(a.y), log(a.z), log(a.w)); }

        // log10
        public static float log10(float x) { return (float)System.Math.Log10((float)x); }
        public static float2 log10(float2 a) { return new float2(log10(a.x), log10(a.y)); }
        public static float3 log10(float3 a) { return new float3(log10(a.x), log10(a.y), log10(a.z)); }
        public static float4 log10(float4 a) { return new float4(log10(a.x), log10(a.y), log10(a.z), log10(a.w)); }

        public static double log10(double x) { return (double)System.Math.Log10((double)x); }
        public static double2 log10(double2 a) { return new double2(log10(a.x), log10(a.y)); }
        public static double3 log10(double3 a) { return new double3(log10(a.x), log10(a.y), log10(a.z)); }
        public static double4 log10(double4 a) { return new double4(log10(a.x), log10(a.y), log10(a.z), log10(a.w)); }

        // mod
        public static float mod(float a, float b) { return a % b; }
        public static float2 mod(float2 a, float2 b) { return new float2(a.x % b.x, a.y % b.y); }
        public static float3 mod(float3 a, float3 b) { return new float3(a.x % b.x, a.y % b.y, a.z % b.z); }
        public static float4 mod(float4 a, float4 b) { return new float4(a.x % b.x, a.y % b.y, a.z % b.z, a.w % b.w); }

        public static double mod(double a, double b) { return a % b; }
        public static double2 mod(double2 a, double2 b) { return new double2(a.x % b.x, a.y % b.y); }
        public static double3 mod(double3 a, double3 b) { return new double3(a.x % b.x, a.y % b.y, a.z % b.z); }
        public static double4 mod(double4 a, double4 b) { return new double4(a.x % b.x, a.y % b.y, a.z % b.z, a.w % b.w); }

        // sqrt
        public static float sqrt(float a) { return (float)System.Math.Sqrt((float)a); }
        public static float2 sqrt(float2 a) { return new float2(sqrt(a.x), sqrt(a.y)); }
        public static float3 sqrt(float3 a) { return new float3(sqrt(a.x), sqrt(a.y), sqrt(a.z)); }
        public static float4 sqrt(float4 a) { return new float4(sqrt(a.x), sqrt(a.y), sqrt(a.z), sqrt(a.w)); }

        public static double sqrt(double a) { return (double)System.Math.Sqrt((double)a); }
        public static double2 sqrt(double2 a) { return new double2(sqrt(a.x), sqrt(a.y)); }
        public static double3 sqrt(double3 a) { return new double3(sqrt(a.x), sqrt(a.y), sqrt(a.z)); }
        public static double4 sqrt(double4 a) { return new double4(sqrt(a.x), sqrt(a.y), sqrt(a.z), sqrt(a.w)); }

        // rsqrt
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float rsqrt(float a) { return 1.0f / sqrt(a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 rsqrt(float2 a) { return 1.0f / sqrt(a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 rsqrt(float3 a) { return 1.0f / sqrt(a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 rsqrt(float4 a) { return 1.0f / sqrt(a); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double rsqrt(double a) { return 1.0 / sqrt(a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 rsqrt(double2 a) { return 1.0 / sqrt(a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 rsqrt(double3 a) { return 1.0 / sqrt(a); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 rsqrt(double4 a) { return 1.0 / sqrt(a); }

        // normalize
        public static float2 normalize(float2 v) { return rsqrt(dot(v, v)) * v; }
        public static float3 normalize(float3 v) { return rsqrt(dot(v, v)) * v; }
        public static float4 normalize(float4 v) { return rsqrt(dot(v, v)) * v; }

        public static double2 normalize(double2 v) { return rsqrt(dot(v, v)) * v; }
        public static double3 normalize(double3 v) { return rsqrt(dot(v, v)) * v; }
        public static double4 normalize(double4 v) { return rsqrt(dot(v, v)) * v; }

        // length
        public static float length(float v) { return abs(v); }
        public static float length(float2 v) { return sqrt(dot(v, v)); }
        public static float length(float3 v) { return sqrt(dot(v, v)); }
        public static float length(float4 v) { return sqrt(dot(v, v)); }

        public static double length(double v) { return abs(v); }
        public static double length(double2 v) { return sqrt(dot(v, v)); }
        public static double length(double3 v) { return sqrt(dot(v, v)); }
        public static double length(double4 v) { return sqrt(dot(v, v)); }

        // length squared
        public static float lengthSquared(float v) { return v*v; }
        public static float lengthSquared(float2 v) { return dot(v, v); }
        public static float lengthSquared(float3 v) { return dot(v, v); }
        public static float lengthSquared(float4 v) { return dot(v, v); }

        public static double lengthSquared(double v) { return v*v; }
        public static double lengthSquared(double2 v) { return dot(v, v); }
        public static double lengthSquared(double3 v) { return dot(v, v); }
        public static double lengthSquared(double4 v) { return dot(v, v); }

        // distance
        public static float distance(float pt1, float pt2) { return length(pt2 - pt1); }
        public static float distance(float2 pt1, float2 pt2) { return length(pt2 - pt1); }
        public static float distance(float3 pt1, float3 pt2) { return length(pt2 - pt1); }
        public static float distance(float4 pt1, float4 pt2) { return length(pt2 - pt1); }

        public static double distance(double pt1, double pt2) { return length(pt2 - pt1); }
        public static double distance(double2 pt1, double2 pt2) { return length(pt2 - pt1); }
        public static double distance(double3 pt1, double3 pt2) { return length(pt2 - pt1); }
        public static double distance(double4 pt1, double4 pt2) { return length(pt2 - pt1); }

        // distance
        public static float distanceSquared(float3 pt1, float3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }

        public static double distanceSquared(double3 pt1, double3 pt2) { return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z; }

        // cross
        public static float3 cross(float3 p0, float3 p1) { return (p0 * p1.yzx - p0.yzx * p1).yzx; }
        public static double3 cross(double3 p0, double3 p1) { return (p0 * p1.yzx - p0.yzx * p1).yzx; }

        // smoothstep
        public static float smoothstep(float a, float b, float x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        public static float2 smoothstep(float2 a, float2 b, float2 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        public static float3 smoothstep(float3 a, float3 b, float3 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        public static float4 smoothstep(float4 a, float4 b, float4 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0f - (2.0f * t));
        }

        public static double smoothstep(double a, double b, double x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double2 smoothstep(double2 a, double2 b, double2 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double3 smoothstep(double3 a, double3 b, double3 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double4 smoothstep(double4 a, double4 b, double4 x)
        {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        // any
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(bool a) { return a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(bool2 a) { return a.x || a.y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(bool3 a) { return a.x || a.y || a.z; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(bool4 a) { return a.x || a.y || a.z || a.w; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(int a) { return a != 0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(int2 a) { return a.x != 0 || a.y != 0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(int3 a) { return a.x != 0 || a.y != 0 || a.z != 0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(int4 a) { return a.x != 0 || a.y != 0 || a.z != 0 || a.w != 0; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(float a) { return a != 0.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(float2 a) { return a.x != 0.0f || a.y != 0.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(float3 a) { return a.x != 0.0f || a.y != 0.0f || a.z != 0.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(float4 a) { return a.x != 0.0f || a.y != 0.0f || a.z != 0.0f || a.w != 0.0f; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(double a) { return a != 0.0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(double2 a) { return a.x != 0.0 || a.y != 0.0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(double3 a) { return a.x != 0.0 || a.y != 0.0 || a.z != 0.0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool any(double4 a) { return a.x != 0.0 || a.y != 0.0 || a.z != 0.0 || a.w != 0.0; }

        // all
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(bool a) { return a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(bool2 a) { return a.x && a.y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(bool3 a) { return a.x && a.y && a.z; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(bool4 a) { return a.x && a.y && a.z && a.w; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(int a) { return a != 0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(int2 a) { return a.x != 0 && a.y != 0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(int3 a) { return a.x != 0 && a.y != 0 && a.z != 0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(int4 a) { return a.x != 0 && a.y != 0 && a.z != 0 && a.w != 0; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(float a) { return a != 0.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(float2 a) { return a.x != 0.0f && a.y != 0.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(float3 a) { return a.x != 0.0f && a.y != 0.0f && a.z != 0.0f; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(float4 a) { return a.x != 0.0f && a.y != 0.0f && a.z != 0.0f && a.w != 0.0f; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(double a) { return a != 0.0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(double2 a) { return a.x != 0.0 && a.y != 0.0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(double3 a) { return a.x != 0.0 && a.y != 0.0 && a.z != 0.0; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool all(double4 a) { return a.x != 0.0 && a.y != 0.0 && a.z != 0.0 && a.w != 0.0; }

        // select
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int select(int a, int b, bool c)    { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int2 select(int2 a, int2 b, bool c) { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int3 select(int3 a, int3 b, bool c) { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int4 select(int4 a, int4 b, bool c) { return c ? b : a; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int2 select(int2 a, int2 b, bool2 c) { return new int2(c.x ? b.x : a.x, c.y ? b.y : a.y); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int3 select(int3 a, int3 b, bool3 c) { return new int3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static int4 select(int4 a, int4 b, bool4 c) { return new int4(c.x ? b.x : a.x, c.y ? a.y : b.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float select(float a, float b, bool c)    { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 select(float2 a, float2 b, bool c) { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 select(float3 a, float3 b, bool c) { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 select(float4 a, float4 b, bool c) { return c ? b : a; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 select(float2 a, float2 b, bool2 c) { return new float2(c.x ? b.x : a.x, c.y ? b.y : a.y); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 select(float3 a, float3 b, bool3 c) { return new float3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 select(float4 a, float4 b, bool4 c) { return new float4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }

        /*
         * @TODO - work out a better fix for this
         * The reason why these have the _d suffix is because the compiler isn't able to infer the correct overload.
         * (they become ambiguous when used with floats)
         */
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double select_d(double a, double b, bool c)    { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 select_d(double2 a, double2 b, bool c) { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 select_d(double3 a, double3 b, bool c) { return c ? b : a; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 select_d(double4 a, double4 b, bool c) { return c ? b : a; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 select_d(double2 a, double2 b, bool2 c) { return new double2(c.x ? b.x : a.x, c.y ? b.y : a.y); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 select_d(double3 a, double3 b, bool3 c) { return new double3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 select_d(double4 a, double4 b, bool4 c) { return new double4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w); }

        // step
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float step(float a, float b) { return select(0.0f, 1.0f, a >= b); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 step(float2 a, float2 b) { return select(0.0f, 1.0f, a >= b); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 step(float3 a, float3 b) { return select(0.0f, 1.0f, a >= b); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 step(float4 a, float4 b) { return select(0.0f, 1.0f, a >= b); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double step(double a, double b) { return select_d(0.0, 1.0, a >= b); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 step(double2 a, double2 b) { return select_d(0.0, 1.0, a >= b); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 step(double3 a, double3 b) { return select_d(0.0, 1.0, a >= b); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 step(double4 a, double4 b) { return select_d(0.0, 1.0, a >= b); }

        // reflect
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float reflect(float i, float n) { return i - 2f * n * dot(i, n); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 reflect(float2 i, float2 n) { return i - 2f * n * dot(i, n); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 reflect(float3 i, float3 n) { return i - 2f * n * dot(i, n); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 reflect(float4 i, float4 n) { return i - 2f * n * dot(i, n); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double reflect(double i, double n) { return i - 2f * n * dot(i, n); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 reflect(double2 i, double2 n) { return i - 2f * n * dot(i, n); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 reflect(double3 i, double3 n) { return i - 2f * n * dot(i, n); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 reflect(double4 i, double4 n) { return i - 2f * n * dot(i, n); }

        // sincos
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(float x, out float s, out float c) { s = sin(x); c = cos(x); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(float2 x, out float2 s, out float2 c) { s = sin(x); c = cos(x); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(float3 x, out float3 s, out float3 c) { s = sin(x); c = cos(x); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(float4 x, out float4 s, out float4 c) { s = sin(x); c = cos(x); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(double x, out double s, out double c) { s = sin(x); c = cos(x); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(double2 x, out double2 s, out double2 c) { s = sin(x); c = cos(x); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(double3 x, out double3 s, out double3 c) { s = sin(x); c = cos(x); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static void sincos(double4 x, out double4 s, out double4 c) { s = sin(x); c = cos(x); }

        // lessThan
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 lessThan(float4 x, float4 y) { return x < y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 lessThan(float3 x, float3 y) { return x < y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 lessThan(float2 x, float2 y) { return x < y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool lessThan(float x, float y) { return x < y; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 lessThan(double4 x, double4 y) { return x < y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 lessThan(double3 x, double3 y) { return x < y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 lessThan(double2 x, double2 y) { return x < y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool lessThan(double x, double y) { return x < y; }

        // lessThanEqual
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 lessThanEqual(float4 x, float4 y) { return x <= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 lessThanEqual(float3 x, float3 y) { return x <= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 lessThanEqual(float2 x, float2 y) { return x <= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool lessThanEqual(float x, float y) { return x <= y; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 lessThanEqual(double4 x, double4 y) { return x <= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 lessThanEqual(double3 x, double3 y) { return x <= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 lessThanEqual(double2 x, double2 y) { return x <= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool lessThanEqual(double x, double y) { return x <= y; }

        // greaterThan
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 greaterThan(float4 x, float4 y) { return x > y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 greaterThan(float3 x, float3 y) { return x > y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 greaterThan(float2 x, float2 y) { return x > y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool greaterThan(float x, float y) { return x > y; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 greaterThan(double4 x, double4 y) { return x > y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 greaterThan(double3 x, double3 y) { return x > y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 greaterThan(double2 x, double2 y) { return x > y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool greaterThan(double x, double y) { return x > y; }

        // greaterThanEqual
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 greaterThanEqual(float4 x, float4 y) { return x >= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 greaterThanEqual(float3 x, float3 y) { return x >= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 greaterThanEqual(float2 x, float2 y) { return x >= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool greaterThanEqual(float x, float y) { return x >= y; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 greaterThanEqual(double4 x, double4 y) { return x >= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 greaterThanEqual(double3 x, double3 y) { return x >= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 greaterThanEqual(double2 x, double2 y) { return x >= y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool greaterThanEqual(double x, double y) { return x >= y; }

        // equal
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 equal(float4 x, float4 y) { return x == y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 equal(float3 x, float3 y) { return x == y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 equal(float2 x, float2 y) { return x == y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool equal(float x, float y) { return x == y; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 equal(double4 x, double4 y) { return x == y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 equal(double3 x, double3 y) { return x == y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 equal(double2 x, double2 y) { return x == y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool equal(double x, double y) { return x == y; }

        // approx
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 approx(float4 x, float4 y) { return new bool4(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z), approx(x.w, y.w)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 approx(float3 x, float3 y) { return new bool3(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 approx(float2 x, float2 y) { return new bool2(approx(x.x, y.x), approx(x.y, y.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool approx(float x, float y) { return abs(x - y) < max(1E-06f * max(abs(x), abs(y)), 1.121039E-44f); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 approx(double4 x, double4 y) { return new bool4(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z), approx(x.w, y.w)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 approx(double3 x, double3 y) { return new bool3(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 approx(double2 x, double2 y) { return new bool2(approx(x.x, y.x), approx(x.y, y.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool approx(double x, double y) { return abs(x - y) < max(1E-06 * max(abs(x), abs(y)), 1.121039E-44); }

        // notEqual
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 notEqual(float4 x, float4 y) { return x != y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 notEqual(float3 x, float3 y) { return x != y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 notEqual(float2 x, float2 y) { return x != y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool notEqual(float x, float y) { return x != y; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool4 notEqual(double4 x, double4 y) { return x != y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool3 notEqual(double3 x, double3 y) { return x != y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool2 notEqual(double2 x, double2 y) { return x != y; }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool notEqual(double x, double y) { return x != y; }

        // cardinals
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 zero3() { return new float3(0.0f,0.0f,0.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 right3() { return new float3(1.0f,0.0f,0.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 left3() { return new float3(-1.0f,0.0f,0.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 up3() { return new float3(0.0f,1.0f,0.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 down3() { return new float3(0.0f,-1.0f,0.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 forward3() { return new float3(0.0f,0.0f,1.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 back3() { return new float3(0.0f,0.0f,-1.0f); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 negativeInfinity3() { return new float3(float.NegativeInfinity,float.NegativeInfinity,float.NegativeInfinity); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 positiveInfinity3() { return new float3(float.PositiveInfinity,float.PositiveInfinity,float.PositiveInfinity); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 zero3d() { return new double3(0.0,0.0,0.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 right3d() { return new double3(1.0,0.0,0.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 left3d() { return new double3(-1.0,0.0,0.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 up3d() { return new double3(0.0,1.0,0.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 down3d() { return new double3(0.0,-1.0,0.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 forward3d() { return new double3(0.0,0.0,1.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 back3d() { return new double3(0.0,0.0,-1.0); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 negativeInfinity3d() { return new double3(double.NegativeInfinity,double.NegativeInfinity,double.NegativeInfinity); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 positiveInfinity3d() { return new double3(double.PositiveInfinity,double.PositiveInfinity,double.PositiveInfinity); }

        // intersects
        public static bool intersects(ray r, bounds box)
        {
            float3 dirfrac = new float3 {
                x = 1.0f / r.direction.x,
                y = 1.0f / r.direction.y,
                z = 1.0f / r.direction.z
            };

            float t1 = (box.min.x - r.origin.x) * dirfrac.x;
            float t2 = (box.max.x - r.origin.x) * dirfrac.x;
            float t3 = (box.min.y - r.origin.y) * dirfrac.y;
            float t4 = (box.max.y - r.origin.y) * dirfrac.y;
            float t5 = (box.min.z - r.origin.z) * dirfrac.z;
            float t6 = (box.max.z - r.origin.z) * dirfrac.z;

            float tmin = max(max(min(t1, t2), min(t3, t4)), min(t5, t6));
            float tmax = min(min(max(t1, t2), max(t3, t4)), max(t5, t6));

            // if tmax < 0, ray (line) is intersecting AABB, but whole AABB is behing us
            if (tmax < 0) {
                return false;
            }

            // if tmin <= tmax, ray intersects AABB
            return tmin <= tmax;
        }

        public static bool intersects(ray_d r, bounds_d box)
        {
            double3 dirfrac = new double3 {
                x = 1.0 / r.direction.x,
                y = 1.0 / r.direction.y,
                z = 1.0 / r.direction.z
            };

            double t1 = (box.min.x - r.origin.x) * dirfrac.x;
            double t2 = (box.max.x - r.origin.x) * dirfrac.x;
            double t3 = (box.min.y - r.origin.y) * dirfrac.y;
            double t4 = (box.max.y - r.origin.y) * dirfrac.y;
            double t5 = (box.min.z - r.origin.z) * dirfrac.z;
            double t6 = (box.max.z - r.origin.z) * dirfrac.z;

            double tmin = max(max(min(t1, t2), min(t3, t4)), min(t5, t6));
            double tmax = min(min(max(t1, t2), max(t3, t4)), max(t5, t6));

            // if tmax < 0, ray (line) is intersecting AABB, but whole AABB is behing us
            if (tmax < 0) {
                return false;
            }

            // if tmin <= tmax, ray intersects AABB
            return tmin <= tmax;
        }

        public static bool intersectsLines(double2 l0p0, double2 l0p1, double2 l1p0, double2 l1p1, ref double2 result)
        {
            double num1 = l0p1.x - l0p0.x;
            double num2 = l0p1.y - l0p0.y;
            double num3 = l1p1.x - l1p0.x;
            double num4 = l1p1.y - l1p0.y;
            double num5 = num1 * num4 - num2 * num3;
            if (equal(num5, 0.0))
                return false;
            double num6 = l1p0.x - l0p0.x;
            double num7 = l1p0.y - l0p0.y;
            double num8 = (num6 * num4 - num7 * num3) / num5;
            result = new double2(l0p0.x + num8 * num1, l0p0.y + num8 * num2);
            return true;
        }

        internal static bool intersectsSegments(double2 l0p0, double2 l0p1, double2 l1p0, double2 l1p1, ref double2 result)
        {
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
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float frsqrt(float a)
        {
            IntFloatUnion u;
            u.intValue = 0;
            float ahalf = 0.5f * a;
            u.floatValue = a;
            u.intValue = 0x5f375a86 - (u.intValue >> 1);
            u.floatValue = u.floatValue * 1 / 5f - ahalf * u.floatValue * u.floatValue;
            return u.floatValue * a;
        }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float2 frsqrt(float2 a) { return new float2(frsqrt(a.x), frsqrt(a.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float3 frsqrt(float3 a) { return new float3(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static float4 frsqrt(float4 a) { return new float4(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z), frsqrt(a.w)); }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double frsqrt(double a)
        {
            LongDoubleUnion u;
            u.longValue = 0;
            double ahalf = 0.5f * a;
            u.doubleValue = a;
            u.longValue = 0x5fe6eb50c7b537a9 - (u.longValue >> 1);
            u.doubleValue = u.doubleValue * 1 / 5f - ahalf * u.doubleValue * u.doubleValue;
            return u.doubleValue * a;
        }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double2 frsqrt(double2 a) { return new double2(frsqrt(a.x), frsqrt(a.y)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double3 frsqrt(double3 a) { return new double3(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z)); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double4 frsqrt(double4 a) { return new double4(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z), frsqrt(a.w)); }

        // http://geomalgorithms.com/a07-_distance.html#dist3D_Segment_to_Segment()
		// you an test distance to a point by setting the first two parameters to the same vector (it doesn't work if the second pair ofcoordinates
		// are the same)
		public static double3[] closestPointsOnSegments (double3 line1p0, double3 line1p1, double3 line2p0, double3 line2p1) {
			const double smallNumber = 0.00000001;

			if (all((equal(line1p0, line1p1) & equal(line2p0, line2p1)))) {
				return new[] {line1p0, line2p0};
			}

		    double3 u = line1p1 - line1p0;
		    double3 v = line2p1 - line2p0;
		    double3 w = line1p0 - line2p0;

			double a = dot(u, u); // always >= 0
			double b = dot(u, v);
			double c = dot(v, v); // always >= 0
			double d = dot(u, w);
			double e = dot(v, w);

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
				sN = (b*e - c*d);
				tN = (a*e - b*d);

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
				}  else {
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
					sN = (-d +  b);
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
            if (all((equal(line1p0, line1p1) & equal(line2p0, line2p1)))) {
                return new[] {line1p0, line2p0};
            }

            float3 u = line1p1 - line1p0;
            float3 v = line2p1 - line2p0;
            float3 w = line1p0 - line2p0;

            float a = dot(u, u); // always >= 0
            float b = dot(u, v);
            float c = dot(v, v); // always >= 0
            float d = dot(u, w);
            float e = dot(v, w);

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
                sN = (b*e - c*d);
                tN = (a*e - b*d);

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
                }  else {
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
                    sN = (-d +  b);
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
    }
}
