﻿using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Unity.Mathematics {
    [StructLayout(LayoutKind.Explicit)]
    struct LongDoubleUnion {
        [FieldOffset(0)]
        public long longValue;

        [FieldOffset(0)]
        public double doubleValue;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LongDoubleUnion (double value) {
            longValue = 0;
            doubleValue = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public LongDoubleUnion (long value) {
            doubleValue = 0;
            longValue = value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static long ToLong (double value) {
            return new LongDoubleUnion(value).longValue;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double ToDouble (long value) {
            return new LongDoubleUnion(value).doubleValue;
        }
    }
}