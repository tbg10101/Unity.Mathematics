using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(double4.DebuggerProxy))]
    [System.Serializable]
    public partial struct double4 : IFormattable
    {
        internal sealed class DebuggerProxy
        {
            public double x;
            public double y;
            public double z;
            public double w;

            public DebuggerProxy(double4 vec)
            {
                x = vec.x;
                y = vec.y;
                z = vec.z;
                w = vec.z;
            }
        }

        public double x;
        public double y;
        public double z;
        public double w;

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double4 xyzw)
        {
            this.x = xyzw.x;
            this.y = xyzw.y;
            this.z = xyzw.z;
            this.w = xyzw.w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }



        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double val) { x = y = z = w = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double2 xy, double2 zw)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = zw.x;
            this.w = zw.y;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double2 xy, double z, double w)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double x, double2 yz, double w)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
            this.w = w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double x, double3 yzw)
        {
            this.x = x;
            this.y = yzw.x;
            this.z = yzw.y;
            this.w = yzw.z;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double x, double y, double2 zw)
        {
            this.x = x;
            this.y = y;
            this.z = zw.x;
            this.w = zw.y;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(double3 xyz, double w)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(int val) { x = y = z = w = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(int4 val)
        {
            this.x = val.x;
            this.y = val.y;
            this.z = val.z;
            this.w = val.w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double4(bool4 val)
        {
            this.x = val.x ? 1.0f : 0.0f;
            this.y = val.y ? 1.0f : 0.0f;
            this.z = val.z ? 1.0f : 0.0f;
            this.w = val.w ? 1.0f : 0.0f;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator double4(double d) { return new double4(d); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator double4(int4 d) { return new double4(d.x, d.y, d.z, d.w); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator double4(float4 d) { return new double4(d.x, d.y, d.z, d.w); }

        public float4 toFloat4() // loss of precision should be explicit
        {
            return new float4(this);
        }
        public int4 toInt4() // loss of precision should be explicit
        {
            return new int4(this);
        }
        public uint4 toUint4() // loss of precision should be explicit
        {
            return new uint4(this);
        }

        public override string ToString()
        {
            return string.Format("double4({0}f, {1}f, {2}f, {3}f)", x, y, z, w);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double4({0}f, {1}f, {2}f, {3}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }
    }
}
