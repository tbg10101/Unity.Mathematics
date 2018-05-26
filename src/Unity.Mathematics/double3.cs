using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#pragma warning disable 0660, 0661
namespace Unity.Mathematics {
    [DebuggerTypeProxy(typeof(DebuggerProxy))]
    [Serializable]
    public partial struct double3 : IFormattable {
        internal sealed class DebuggerProxy {
            public double x;
            public double y;
            public double z;

            public DebuggerProxy (double3 vec) {
                x = vec.x;
                y = vec.y;
                z = vec.z;
            }
        }

        public double x;
        public double y;
        public double z;

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public double3 (double x, double y, double z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public double3 (double val) {
            x = y = z = val;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public double3 (double2 xy, double z) {
            x = xy.x;
            y = xy.y;
            this.z = z;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public double3 (double x, double2 yz) {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public double3 (int val) {
            x = y = z = val;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public double3 (int3 val) {
            x = val.x;
            y = val.y;
            z = val.z;
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static implicit operator double3 (double d) {
            return new double3(d);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static implicit operator double3 (int3 d) {
            return new double3(d.x, d.y, d.z);
        }

        [MethodImpl((MethodImplOptions) 0x100)] // agressive inline
        public static implicit operator double3 (float3 d) {
            return new double3(d.x, d.y, d.z);
        }

        public float3 toFloat3 () // loss of precision should be explicit
        {
            return new float3((float) x, (float) y, (float) z);
        }

        public int3 toInt3 () // loss of precision should be explicit
        {
            return new int3((int) x, (int) y, (int) z);
        }

        public uint3 toUint3 () // loss of precision should be explicit
        {
            return new uint3((uint) x, (uint) y, (uint) z);
        }

        public override string ToString () {
            return string.Format("double3({0}f, {1}f, {2}f)", x, y, z);
        }

        public string ToString (string format, IFormatProvider formatProvider) {
            return string.Format(
                "double3({0}f, {1}f, {2}f)",
                x.ToString(format, formatProvider),
                y.ToString(format, formatProvider),
                z.ToString(format, formatProvider));
        }
    }
}