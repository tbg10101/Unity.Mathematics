using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics
{
    [StructLayout(LayoutKind.Explicit)]
    internal struct LongDoubleUnion
    {
        [FieldOffset(0)]
        public long longValue;
        [FieldOffset(0)]
        public double doubleValue;

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public LongDoubleUnion(double value)
        {
            longValue = 0;
            doubleValue = value;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public LongDoubleUnion(long value)
        {
            doubleValue = 0;
            longValue = value;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static long ToLong(double value)
        {
            return new LongDoubleUnion(value).longValue;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static double ToDouble(long value)
        {
            return new LongDoubleUnion(value).doubleValue;
        }
    }
}
