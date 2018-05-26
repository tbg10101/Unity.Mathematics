using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(double2.DebuggerProxy))]
    [System.Serializable]
    public partial struct double2 : IFormattable
    {
        internal sealed class DebuggerProxy
        {
            public double x;
            public double y;

            public DebuggerProxy(double2 vec)
            {
                x = vec.x;
                y = vec.y;
            }
        }

        public double x;
        public double y;

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double2(double val) { x = y = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double2(int val) { x = y = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public double2(int2 val)
        {
            this.x = val.x;
            this.y = val.y;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator double2(double d) { return new double2(d); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator double2(int2 d) { return new double2(d.x, d.y); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator double2(float2 d) { return new double2(d.x, d.y); }

        public float2 toFloat2() // loss of precision should be explicit
        {
            return new float2(this);
        }
        public int2 toInt2() // loss of precision should be explicit
        {
            return new int2(this);
        }
        public uint2 toUint2() // loss of precision should be explicit
        {
            return new uint2(this);
        }

        public override string ToString()
        {
            return string.Format("double2({0:R}f, {1:R}f)", x, y);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("double2({0}f, {1}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }
    }
}
