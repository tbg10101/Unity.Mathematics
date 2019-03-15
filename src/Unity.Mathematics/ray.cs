using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Unity.Mathematics {
    public struct ray : IEquatable<ray> {
        public float3 origin;
        public float3 direction;

        public float3 tip => origin + direction;

        public ray (float3 origin, float3 direction) {
            this.origin = origin;
            this.direction = math.normalize(direction);
        }

        public static implicit operator ray (Ray r) {
            return new ray(r.origin, r.direction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals (ray other) {
            return origin.Equals(other.origin) && direction.Equals(other.direction);
        }

        public override bool Equals (object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ray && Equals((ray) obj);
        }

		public override int GetHashCode () {
			return (int)(math.hash(origin) + math.hash(direction));
		}
    }

    public struct ray_d : IEquatable<ray_d> {
        public double3 origin;
        public double3 direction;

        public double3 tip => origin + direction;

        public ray_d (double3 origin, double3 direction) {
            this.origin = origin;
            this.direction = math.normalize(direction);
        }

        public ray_d (ray r) {
            origin = r.origin;
            direction = r.direction;
        }

        public static implicit operator ray_d (ray r) {
            return new ray_d(r);
        }

        public ray toRay () { // loss of precision should be explicit
            return new ray(origin.toFloat3(), direction.toFloat3());
        }

        public static implicit operator ray_d (Ray r) {
            return new ray_d(new double3(r.origin.x, r.origin.y, r.origin.z), new double3(r.direction.x, r.direction.y, r.direction.z));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals (ray_d other) {
            return origin.Equals(other.origin) && direction.Equals(other.direction);
        }

        public override bool Equals (object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ray_d && Equals((ray_d) obj);
        }

        public override int GetHashCode () {
            return 17 * (int)(math.hash(origin) + math.hash(direction));
        }
    }

    public static partial class math_x {
        public static ray ray (float3 origin, float3 direction) {
            return new ray(origin, direction);
        }

        public static ray_d ray_d (double3 origin, double3 direction) {
            return new ray_d(origin, direction);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float3 point (ray r, float distance) {
            return r.origin + distance * r.direction;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double3 point (ray_d r, double distance) {
            return r.origin + distance * r.direction;
        }
    }
}
