using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(float2.DebuggerProxy))]
    [System.Serializable]
    public partial struct float2 : IFormattable
    {
        internal sealed class DebuggerProxy
        {
            public float x;
            public float y;

            public DebuggerProxy(float2 vec)
            {
                x = vec.x;
                y = vec.y;
            }
        }

        public float x;
        public float y;

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public float2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public float2(float val) { x = y = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public float2(int val) { x = y = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public float2(int2 val)
        {
            this.x = val.x;
            this.y = val.y;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public float2(double2 val)
        {
            this.x = (float)val.x;
            this.y = (float)val.y;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator float2(float d) { return new float2(d); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator float2(int2 d) { return new float2(d.x, d.y); }

        // loss of precision should be explicit
        // [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        // public static implicit operator float2(double2 d) { return new float2((float)d.x, (float)d.y); }

        public override string ToString()
        {
            return string.Format("float2({0:R}f, {1:R}f)", x, y);
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("float2({0}f, {1}f)", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }
    }
}

