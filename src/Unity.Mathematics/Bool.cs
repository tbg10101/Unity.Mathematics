using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics {
	[Serializable]

	public struct Bool : IEquatable<Bool> {
		private readonly byte _value;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Bool (byte value) {
			_value = value;
		}

		public static implicit operator Bool (bool b) => new Bool(Convert.ToByte(b));

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator bool (Bool b) => b._value == 1;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Equals (Bool other) => _value == other._value;

		public override bool Equals (object obj) {
			if (ReferenceEquals(null, obj)) return false;
			return obj is Bool && Equals((Bool) obj);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetHashCode () => _value;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string ToString() => $"Bool({_value})";
	}
}
