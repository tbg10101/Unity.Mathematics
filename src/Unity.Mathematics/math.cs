// * TODO: Validate -1 vs 1 behaviour in math lib. eg < returns 0 / -1
//   Check if all operators act accordingly
// * Also int3 etc bool casts? should they exist?
// * Should we allow float4 value = 5; it is convenient and how it is in hlsl but maybe not the right fit in C#?

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics {
    public static partial class math_x {
        public const float pi = 3.14159265358979f;
        public const float infinity = float.PositiveInfinity;
        public const float negativeInfinity = float.NegativeInfinity;
        public const float deg2Rad = 0.01745329f;
        public const float rad2Deg = 57.29578f;
        private const float epsilon = 0.000001F;

        public const double pi_d = 3.14159265358979;
        public const double infinity_d = double.PositiveInfinity;
        public const double negativeInfinity_d = double.NegativeInfinity;
        public const double deg2Rad_d = 0.01745329;
        public const double rad2Deg_d = 57.29578;
        private const double epsilon_d = 0.000001;

        // min
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double min (double a, double b) {
            return double.IsNaN(b) || a < b ? a : b;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 min (double2 a, double2 b) {
            return new double2(min(a.x, b.x), min(a.y, b.y));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 min (double3 a, double3 b) {
            return new double3(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 min (double4 a, double4 b) {
            return new double4(min(a.x, b.x), min(a.y, b.y), min(a.z, b.z), min(a.w, b.w));
        }

        // max
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double max (double a, double b) {
            return double.IsNaN(b) || a > b ? a : b;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 max (double2 a, double2 b) {
            return new double2(max(a.x, b.x), max(a.y, b.y));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 max (double3 a, double3 b) {
            return new double3(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 max (double4 a, double4 b) {
            return new double4(max(a.x, b.x), max(a.y, b.y), max(a.z, b.z), max(a.w, b.w));
        }

        // lerp
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double lerp (double a, double b, double w) {
            return a + w * (b - a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 lerp (double2 a, double2 b, double w) {
            return a + w * (b - a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 lerp (double3 a, double3 b, double w) {
            return a + w * (b - a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 lerp (double4 a, double4 b, double w) {
            return a + w * (b - a);
        }

        // mad
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double mad (double a, double b, double c) {
            return a * b + c;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 mad (double2 a, double2 b, double2 c) {
            return a * b + c;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 mad (double3 a, double3 b, double3 c) {
            return a * b + c;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 mad (double4 a, double4 b, double4 c) {
            return a * b + c;
        }

        // TODO: madint version????


        // clamp
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double clamp (double x, double a, double b) {
            return max(a, min(b, x));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 clamp (double2 x, double2 a, double2 b) {
            return max(a, min(b, x));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 clamp (double3 x, double3 a, double3 b) {
            return max(a, min(b, x));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 clamp (double4 x, double4 a, double4 b) {
            return max(a, min(b, x));
        }

        // saturate
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double saturate (double x) {
            return clamp(x, 0.0, 1.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 saturate (double2 x) {
            return clamp(x, new double2(0.0), new double2(1.0));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 saturate (double3 x) {
            return clamp(x, new double3(0.0), new double3(1.0));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 saturate (double4 x) {
            return clamp(x, new double4(0.0), new double4(1.0));
        }

        // abs
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double abs (double a) {
            return max(-a, a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 abs (double2 a) {
            return max(-a, a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 abs (double3 a) {
            return max(-a, a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 abs (double4 a) {
            return max(-a, a);
        }

        // dot
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double dot (double pt1, double pt2) {
            return pt1 * pt2;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double dot (double2 pt1, double2 pt2) {
            return pt1.x * pt2.x + pt1.y * pt2.y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double dot (double3 pt1, double3 pt2) {
            return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double dot (double4 pt1, double4 pt2) {
            return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z + pt1.w * pt2.w;
        }

        // avg
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float avg (float pt1, float pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float2 avg (float2 pt1, float2 pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float3 avg (float3 pt1, float3 pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float4 avg (float4 pt1, float4 pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double avg (double pt1, double pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 avg (double2 pt1, double2 pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 avg (double3 pt1, double3 pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 avg (double4 pt1, double4 pt2) {
            return (pt1 + pt2) / 2.0f;
        }

        // tan
        public static double tan (double value) {
            return Math.Tan(value);
        }

        public static double2 tan (double2 value) {
            return new double2(tan(value.x), tan(value.y));
        }

        public static double3 tan (double3 value) {
            return new double3(tan(value.x), tan(value.y), tan(value.z));
        }

        public static double4 tan (double4 value) {
            return new double4(tan(value.x), tan(value.y), tan(value.z), tan(value.w));
        }

        // atan
        public static double atan (double value) {
            return Math.Atan(value);
        }

        public static double2 atan (double2 value) {
            return new double2(atan(value.x), atan(value.y));
        }

        public static double3 atan (double3 value) {
            return new double3(atan(value.x), atan(value.y), atan(value.z));
        }

        public static double4 atan (double4 value) {
            return new double4(atan(value.x), atan(value.y), atan(value.z), atan(value.w));
        }

        // atan2
        public static double atan2 (double pt1, double pt2) {
            return Math.Atan2(pt1, pt2);
        }

        public static double2 atan2 (double2 pt1, double2 pt2) {
            return new double2(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y));
        }

        public static double3 atan2 (double3 pt1, double3 pt2) {
            return new double3(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z));
        }

        public static double4 atan2 (double4 pt1, double4 pt2) {
            return new double4(atan2(pt1.x, pt2.x), atan2(pt1.y, pt2.y), atan2(pt1.z, pt2.z), atan2(pt1.w, pt2.w));
        }

        // cos
        public static double cos (double a) {
            return Math.Cos(a);
        }

        public static double2 cos (double2 a) {
            return new double2(cos(a.x), cos(a.y));
        }

        public static double3 cos (double3 a) {
            return new double3(cos(a.x), cos(a.y), cos(a.z));
        }

        public static double4 cos (double4 a) {
            return new double4(cos(a.x), cos(a.y), cos(a.z), cos(a.w));
        }

        // acos
        public static double acos (double a) {
            return Math.Acos(a);
        }

        public static double2 acos (double2 a) {
            return new double2(acos(a.x), acos(a.y));
        }

        public static double3 acos (double3 a) {
            return new double3(acos(a.x), acos(a.y), acos(a.z));
        }

        public static double4 acos (double4 a) {
            return new double4(acos(a.x), acos(a.y), acos(a.z), acos(a.w));
        }

        // sin
        public static double sin (double a) {
            return Math.Sin(a);
        }

        public static double2 sin (double2 a) {
            return new double2(sin(a.x), sin(a.y));
        }

        public static double3 sin (double3 a) {
            return new double3(sin(a.x), sin(a.y), sin(a.z));
        }

        public static double4 sin (double4 a) {
            return new double4(sin(a.x), sin(a.y), sin(a.z), sin(a.w));
        }

        // asin
        public static double asin (double a) {
            return Math.Asin(a);
        }

        public static double2 asin (double2 a) {
            return new double2(asin(a.x), asin(a.y));
        }

        public static double3 asin (double3 a) {
            return new double3(asin(a.x), asin(a.y), asin(a.z));
        }

        public static double4 asin (double4 a) {
            return new double4(asin(a.x), asin(a.y), asin(a.z), asin(a.w));
        }

        // floor
        public static double floor (double a) {
            return Math.Floor(a);
        }

        public static double2 floor (double2 a) {
            return new double2(floor(a.x), floor(a.y));
        }

        public static double3 floor (double3 a) {
            return new double3(floor(a.x), floor(a.y), floor(a.z));
        }

        public static double4 floor (double4 a) {
            return new double4(floor(a.x), floor(a.y), floor(a.z), floor(a.w));
        }

        // ceil
        public static double ceil (double a) {
            return Math.Ceiling(a);
        }

        public static double2 ceil (double2 a) {
            return new double2(ceil(a.x), ceil(a.y));
        }

        public static double3 ceil (double3 a) {
            return new double3(ceil(a.x), ceil(a.y), ceil(a.z));
        }

        public static double4 ceil (double4 a) {
            return new double4(ceil(a.x), ceil(a.y), ceil(a.z), ceil(a.w));
        }

        // round
        public static double round (double a) {
            return Math.Round(a);
        }

        public static double2 round (double2 a) {
            return new double2(round(a.x), round(a.y));
        }

        public static double3 round (double3 a) {
            return new double3(round(a.x), round(a.y), round(a.z));
        }

        public static double4 round (double4 a) {
            return new double4(round(a.x), round(a.y), round(a.z), round(a.w));
        }

        // frac
        public static double frac (double a) {
            return a - floor(a);
        }

        public static double2 frac (double2 a) {
            return a - floor(a);
        }

        public static double3 frac (double3 a) {
            return a - floor(a);
        }

        public static double4 frac (double4 a) {
            return a - floor(a);
        }

        // rcp
        public static double rcp (double a) {
            return 1f / a;
        }

        public static double2 rcp (double2 a) {
            return 1f / a;
        }

        public static double3 rcp (double3 a) {
            return 1f / a;
        }

        public static double4 rcp (double4 a) {
            return 1f / a;
        }

        // sign
        public static double sign (double f) {
            return f == 0f ? 0f : (f > 0f ? 1f : 0.0) - (f < 0f ? 1.0 : 0.0);
        }

        public static double2 sign (double2 f) {
            return new double2(sign(f.x), sign(f.y));
        }

        public static double3 sign (double3 f) {
            return new double3(sign(f.x), sign(f.y), sign(f.z));
        }

        public static double4 sign (double4 f) {
            return new double4(sign(f.x), sign(f.y), sign(f.z), sign(f.w));
        }

        // mix
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double mix (double a, double b, double x) {
            return x * (b - a) + a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 mix (double2 a, double2 b, double2 x) {
            return x * (b - a) + a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 mix (double3 a, double3 b, double3 x) {
            return x * (b - a) + a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 mix (double4 a, double4 b, double4 x) {
            return x * (b - a) + a;
        }

        // pow
        public static double pow (double a, double b) {
            return Math.Pow(a, b);
        }

        public static double2 pow (double2 a, double2 b) {
            return new double2(pow(a.x, b.x), pow(a.y, b.y));
        }

        public static double3 pow (double3 a, double3 b) {
            return new double3(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z));
        }

        public static double4 pow (double4 a, double4 b) {
            return new double4(pow(a.x, b.x), pow(a.y, b.y), pow(a.z, b.z), pow(a.w, b.w));
        }

        // powr - assumes sign of a is 0 or greater
        public static double powr (double a, double b) {
            return pow(a, b);
        }

        public static double2 powr (double2 a, double2 b) {
            return pow(a, b);
        }

        public static double3 powr (double3 a, double3 b) {
            return pow(a, b);
        }

        public static double4 powr (double4 a, double4 b) {
            return pow(a, b);
        }

        // exp
        public static double exp (double x) {
            return Math.Exp(x);
        }

        public static double2 exp (double2 a) {
            return new double2(exp(a.x), exp(a.y));
        }

        public static double3 exp (double3 a) {
            return new double3(exp(a.x), exp(a.y), exp(a.z));
        }

        public static double4 exp (double4 a) {
            return new double4(exp(a.x), exp(a.y), exp(a.z), exp(a.w));
        }

        // log
        public static double log (double x) {
            return Math.Log(x);
        }

        public static double2 log (double2 a) {
            return new double2(log(a.x), log(a.y));
        }

        public static double3 log (double3 a) {
            return new double3(log(a.x), log(a.y), log(a.z));
        }

        public static double4 log (double4 a) {
            return new double4(log(a.x), log(a.y), log(a.z), log(a.w));
        }

        // log10
        public static double log10 (double x) {
            return Math.Log10(x);
        }

        public static double2 log10 (double2 a) {
            return new double2(log10(a.x), log10(a.y));
        }

        public static double3 log10 (double3 a) {
            return new double3(log10(a.x), log10(a.y), log10(a.z));
        }

        public static double4 log10 (double4 a) {
            return new double4(log10(a.x), log10(a.y), log10(a.z), log10(a.w));
        }

        // mod
        public static double mod (double a, double b) {
            return a % b;
        }

        public static double2 mod (double2 a, double2 b) {
            return new double2(a.x % b.x, a.y % b.y);
        }

        public static double3 mod (double3 a, double3 b) {
            return new double3(a.x % b.x, a.y % b.y, a.z % b.z);
        }

        public static double4 mod (double4 a, double4 b) {
            return new double4(a.x % b.x, a.y % b.y, a.z % b.z, a.w % b.w);
        }

        // sqrt
        public static double sqrt (double a) {
            return Math.Sqrt(a);
        }

        public static double2 sqrt (double2 a) {
            return new double2(sqrt(a.x), sqrt(a.y));
        }

        public static double3 sqrt (double3 a) {
            return new double3(sqrt(a.x), sqrt(a.y), sqrt(a.z));
        }

        public static double4 sqrt (double4 a) {
            return new double4(sqrt(a.x), sqrt(a.y), sqrt(a.z), sqrt(a.w));
        }

        // rsqrt
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double rsqrt (double a) {
            return 1.0 / sqrt(a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 rsqrt (double2 a) {
            return 1.0 / sqrt(a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 rsqrt (double3 a) {
            return 1.0 / sqrt(a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 rsqrt (double4 a) {
            return 1.0 / sqrt(a);
        }

        // normalize
        public static double2 normalize (double2 v) {
            return rsqrt(dot(v, v)) * v;
        }

        public static double3 normalize (double3 v) {
            return rsqrt(dot(v, v)) * v;
        }

        public static double4 normalize (double4 v) {
            return rsqrt(dot(v, v)) * v;
        }

        // length
        public static double length (double v) {
            return abs(v);
        }

        public static double length (double2 v) {
            return sqrt(dot(v, v));
        }

        public static double length (double3 v) {
            return sqrt(dot(v, v));
        }

        public static double length (double4 v) {
            return sqrt(dot(v, v));
        }

        // length squared
        public static double lengthSquared (double v) {
            return v * v;
        }

        public static double lengthSquared (double2 v) {
            return dot(v, v);
        }

        public static double lengthSquared (double3 v) {
            return dot(v, v);
        }

        public static double lengthSquared (double4 v) {
            return dot(v, v);
        }

        // distance
        public static double distance (double pt1, double pt2) {
            return length(pt2 - pt1);
        }

        public static double distance (double2 pt1, double2 pt2) {
            return length(pt2 - pt1);
        }

        public static double distance (double3 pt1, double3 pt2) {
            return length(pt2 - pt1);
        }

        public static double distance (double4 pt1, double4 pt2) {
            return length(pt2 - pt1);
        }

        // distance squared
        public static float distanceSquared (float3 pt1, float3 pt2) {
            return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z;
        }

        public static double distanceSquared (double3 pt1, double3 pt2) {
            return pt1.x * pt2.x + pt1.y * pt2.y + pt1.z * pt2.z;
        }

        // cross
        public static float3 cross (float3 p0, float3 p1) {
            return (p0 * p1.yzx - p0.yzx * p1).yzx;
        }

        public static double3 cross (double3 p0, double3 p1) {
            return (p0 * p1.yzx - p0.yzx * p1).yzx;
        }

        // smoothstep
        public static double smoothstep (double a, double b, double x) {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double2 smoothstep (double2 a, double2 b, double2 x) {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double3 smoothstep (double3 a, double3 b, double3 x) {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        public static double4 smoothstep (double4 a, double4 b, double4 x) {
            var t = saturate((x - a) / (b - a));
            return t * t * (3.0 - (2.0 * t));
        }

        // any
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool any (double a) {
            return a != 0.0;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool any (double2 a) {
            return a.x != 0.0 || a.y != 0.0;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool any (double3 a) {
            return a.x != 0.0 || a.y != 0.0 || a.z != 0.0;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool any (double4 a) {
            return a.x != 0.0 || a.y != 0.0 || a.z != 0.0 || a.w != 0.0;
        }

        // all
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool all (double a) {
            return a != 0.0;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool all (double2 a) {
            return a.x != 0.0 && a.y != 0.0;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool all (double3 a) {
            return a.x != 0.0 && a.y != 0.0 && a.z != 0.0;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool all (double4 a) {
            return a.x != 0.0 && a.y != 0.0 && a.z != 0.0 && a.w != 0.0;
        }

        // select
        /*
         * @TODO - work out a better fix for this
         * The reason why these have the _d suffix is because the compiler isn't able to infer the correct overload.
         * (they become ambiguous when used with floats)
         */
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double select (double a, double b, bool c) {
            return c ? b : a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 select (double2 a, double2 b, bool c) {
            return c ? b : a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 select (double3 a, double3 b, bool c) {
            return c ? b : a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 select (double4 a, double4 b, bool c) {
            return c ? b : a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 select (double2 a, double2 b, bool2 c) {
            return new double2(c.x ? b.x : a.x, c.y ? b.y : a.y);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 select (double3 a, double3 b, bool3 c) {
            return new double3(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 select (double4 a, double4 b, bool4 c) {
            return new double4(c.x ? b.x : a.x, c.y ? b.y : a.y, c.z ? b.z : a.z, c.w ? b.w : a.w);
        }

        // step
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double step (double a, double b) {
            return select(0.0, 1.0, b >= a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 step (double2 a, double2 b) {
            return select(0.0, 1.0, b >= a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 step (double3 a, double3 b) {
            return select(0.0, 1.0, b >= a);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 step (double4 a, double4 b) {
            return select(0.0, 1.0, b >= a);
        }

        // reflect
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double reflect (double i, double n) {
            return i - 2f * n * dot(i, n);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 reflect (double2 i, double2 n) {
            return i - 2f * n * dot(i, n);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 reflect (double3 i, double3 n) {
            return i - 2f * n * dot(i, n);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 reflect (double4 i, double4 n) {
            return i - 2f * n * dot(i, n);
        }

        // sincos
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static void sincos (double x, out double s, out double c) {
            s = sin(x);
            c = cos(x);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static void sincos (double2 x, out double2 s, out double2 c) {
            s = sin(x);
            c = cos(x);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static void sincos (double3 x, out double3 s, out double3 c) {
            s = sin(x);
            c = cos(x);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static void sincos (double4 x, out double4 s, out double4 c) {
            s = sin(x);
            c = cos(x);
        }

        // lessThan
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool4 lessThan (double4 x, double4 y) {
            return x < y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool3 lessThan (double3 x, double3 y) {
            return x < y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool2 lessThan (double2 x, double2 y) {
            return x < y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool lessThan (double x, double y) {
            return x < y;
        }

        // lessThanEqual
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool4 lessThanEqual (double4 x, double4 y) {
            return x <= y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool3 lessThanEqual (double3 x, double3 y) {
            return x <= y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool2 lessThanEqual (double2 x, double2 y) {
            return x <= y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool lessThanEqual (double x, double y) {
            return x <= y;
        }

        // greaterThan
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool4 greaterThan (double4 x, double4 y) {
            return x > y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool3 greaterThan (double3 x, double3 y) {
            return x > y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool2 greaterThan (double2 x, double2 y) {
            return x > y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool greaterThan (double x, double y) {
            return x > y;
        }

        // greaterThanEqual
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool4 greaterThanEqual (double4 x, double4 y) {
            return x >= y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool3 greaterThanEqual (double3 x, double3 y) {
            return x >= y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool2 greaterThanEqual (double2 x, double2 y) {
            return x >= y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool greaterThanEqual (double x, double y) {
            return x >= y;
        }

        // equal
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool4 equal (double4 x, double4 y) {
            return x == y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool3 equal (double3 x, double3 y) {
            return x == y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool2 equal (double2 x, double2 y) {
            return x == y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool equal (double x, double y) {
            return x == y;
        }

        // approx
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool4 approx (double4 x, double4 y) {
            return new bool4(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z), approx(x.w, y.w));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool3 approx (double3 x, double3 y) {
            return new bool3(approx(x.x, y.x), approx(x.y, y.y), approx(x.z, y.z));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool2 approx (double2 x, double2 y) {
            return new bool2(approx(x.x, y.x), approx(x.y, y.y));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool approx (double x, double y) {
            return abs(x - y) < max(1E-06 * max(abs(x), abs(y)), 1.121039E-44);
        }

        // notEqual
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool4 notEqual (double4 x, double4 y) {
            return x != y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool3 notEqual (double3 x, double3 y) {
            return x != y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool2 notEqual (double2 x, double2 y) {
            return x != y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static bool notEqual (double x, double y) {
            return x != y;
        }

        // cardinals
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 zero3d () {
            return new double3(0.0, 0.0, 0.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 right3d () {
            return new double3(1.0, 0.0, 0.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 left3d () {
            return new double3(-1.0, 0.0, 0.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 up3d () {
            return new double3(0.0, 1.0, 0.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 down3d () {
            return new double3(0.0, -1.0, 0.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 forward3d () {
            return new double3(0.0, 0.0, 1.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 back3d () {
            return new double3(0.0, 0.0, -1.0);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 negativeInfinity3d () {
            return new double3(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 positiveInfinity3d () {
            return new double3(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);
        }

        // intersects
        public static bool intersects (ray r, bounds box) {
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

            float tmin = math.max(math.max(math.min(t1, t2), math.min(t3, t4)), math.min(t5, t6));
            float tmax = math.min(math.min(math.max(t1, t2), math.max(t3, t4)), math.max(t5, t6));

            // if tmax < 0, ray (line) is intersecting AABB, but whole AABB is behing us
            if (tmax < 0) {
                return false;
            }

            // if tmin <= tmax, ray intersects AABB
            return tmin <= tmax;
        }

        public static bool intersects (ray_d r, bounds_d box) {
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

        public static bool intersectsLines (double2 l0p0, double2 l0p1, double2 l1p0, double2 l1p1, ref double2 result) {
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
        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float frsqrt (float a) {
            IntFloatUnion u;
            u.intValue = 0;
            float ahalf = 0.5f * a;
            u.floatValue = a;
            u.intValue = 0x5f375a86 - (u.intValue >> 1);
            u.floatValue = u.floatValue * 1 / 5f - ahalf * u.floatValue * u.floatValue;
            return u.floatValue * a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float2 frsqrt (float2 a) {
            return new float2(frsqrt(a.x), frsqrt(a.y));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float3 frsqrt (float3 a) {
            return new float3(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static float4 frsqrt (float4 a) {
            return new float4(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z), frsqrt(a.w));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double frsqrt (double a) {
            LongDoubleUnion u;
            u.longValue = 0;
            double ahalf = 0.5f * a;
            u.doubleValue = a;
            u.longValue = 0x5fe6eb50c7b537a9 - (u.longValue >> 1);
            u.doubleValue = u.doubleValue * 1 / 5f - ahalf * u.doubleValue * u.doubleValue;
            return u.doubleValue * a;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double2 frsqrt (double2 a) {
            return new double2(frsqrt(a.x), frsqrt(a.y));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double3 frsqrt (double3 a) {
            return new double3(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z));
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static double4 frsqrt (double4 a) {
            return new double4(frsqrt(a.x), frsqrt(a.y), frsqrt(a.z), frsqrt(a.w));
        }

        // http://geomalgorithms.com/a07-_distance.html#dist3D_Segment_to_Segment()
        // you an test distance to a point by setting the first two parameters to the same vector (it doesn't work if the second pair ofcoordinates
        // are the same)
        public static double3[] closestPointsOnSegments (double3 line1p0, double3 line1p1, double3 line2p0, double3 line2p1) {
            const double smallNumber = 0.00000001;

            if (math.all((equal(line1p0, line1p1) & equal(line2p0, line2p1)))) {
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
            if (math.all((math.equal(line1p0, line1p1) & math.equal(line2p0, line2p1)))) {
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
            return math.distance(points[0], points[1]);
        }

        public static float closestSegmentToSegmentSqrDistance (float3 line1p0, float3 line1p1, float3 line2p0, float3 line2p1) {
            float3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
            return distanceSquared(points[0], points[1]);
        }

        public static float3 closestSegmentToSegmentMidPoint (float3 line1p0, float3 line1p1, float3 line2p0, float3 line2p1) {
            float3[] points = closestPointsOnSegments(line1p0, line1p1, line2p0, line2p1);
            return avg(points[0], points[1]);
        }

        public static float4 toFloat4(this Color c) {
            return new float4(c.r, c.g, c.b, c.a);
        }
    }
}
