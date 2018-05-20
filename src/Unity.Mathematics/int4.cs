using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(int4.DebuggerProxy))]
    [System.Serializable]
    public partial struct int4
    {
        internal sealed class DebuggerProxy
        {
            public int x;
            public int y;
            public int z;
            public int w;

            public DebuggerProxy(int4 vec)
            {
                x = vec.x;
                y = vec.y;
                z = vec.z;
                w = vec.z;
            }
        }

        public int x;
        public int y;
        public int z;
        public int w;

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public int4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public int4 (int val) { this.x = this.y = this.z = this.w = val; }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public int4 (int3 xyz, int w)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public int4 (float4 val)
        {
            this.x = (int)val.x;
            this.y = (int)val.y;
            this.z = (int)val.z;
            this.w = (int)val.w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public int4 (double4 val)
        {
            this.x = (int)val.x;
            this.y = (int)val.y;
            this.z = (int)val.z;
            this.w = (int)val.w;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static implicit operator int4(int d) { return new int4(d); }
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static explicit operator int4(float4 d) { return new int4(d); }

        public override string ToString()
        {
            return string.Format("int4({0}, {1}, {2}, {3})", x, y, z, w);
        }
    }
}

