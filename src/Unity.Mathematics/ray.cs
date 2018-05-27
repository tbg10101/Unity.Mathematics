using UnityEngine;

namespace Unity.Mathematics {
    public struct ray {
        public float3 origin;
        public float3 direction;

        public float3 tip => origin + direction;

        public ray (float3 origin, float3 direction) {
            this.origin = origin;
            this.direction = math.normalize(direction);
        }

        public ray (ray_d r) {
            origin = r.origin.toFloat3();
            direction = r.direction.toFloat3();
        }

        public static implicit operator ray (Ray r) {
            return new ray(r.origin, r.direction);
        }
    }

    public struct ray_d {
        public double3 origin;
        public double3 direction;

        public double3 tip => origin + direction;

        public ray_d (double3 origin, double3 direction) {
            this.origin = origin;
            this.direction = math_x.normalize(direction);
        }

        public ray_d (ray r) {
            origin = r.origin;
            direction = r.direction;
        }


        public static implicit operator ray_d (ray r) {
            return new ray_d(r);
        }

        public ray toRay () { // loss of precision should be explicit
            return new ray(this);
        }

        public static implicit operator ray_d (Ray r) {
            return new ray_d(new double3(r.origin.x, r.origin.y, r.origin.z), new double3(r.direction.x, r.direction.y, r.direction.z));
        }
    }

    public static partial class math_x {
        public static float3 point (ray r, float distance) {
            return r.origin + distance * r.direction;
        }

        public static double3 point (ray_d r, double distance) {
            return r.origin + distance * r.direction;
        }

        public static bool equal (ray r0, ray r1) {
            return math.all(math.equal(r0.origin, r1.origin) & math.equal(r0.direction, r1.direction));
        }

        public static bool equal (ray_d r0, ray_d r1) {
            return math.all(equal(r0.origin, r1.origin) & equal(r0.direction, r1.direction));
        }
    }
}