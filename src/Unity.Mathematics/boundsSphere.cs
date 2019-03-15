using System;
using System.Runtime.CompilerServices;

namespace Unity.Mathematics {
    public struct boundsSphere : IEquatable<boundsSphere> {
        private float3 _center;
        public float3 center {
            get {
                return _center;
            }
            set {
                _center = value;
            }
        }

        private float _radius;
        public float radius {
            get {
                return _radius;
            }
            set {
                _radius = value;

                _diameter = 2.0f * _radius;
            }
        }

        private float _diameter;
        public float diameter {
            get {
                return _diameter;
            }
            set {
                _diameter = value;

                _radius = _diameter / 2.0f;
            }
        }

        public boundsSphere (float3 center, float radius) {
            _center = center;
            _radius = radius;
            _diameter = 2.0f * radius;
        }

        public void ConformTo (float3 v0, float3 v1) {
            _center = (v0 + v1) / 2.0f;
            diameter = math.length(v0 - v1);
        }

        public void ConformTo (boundsSphere v0, boundsSphere v1) {
            float3 betweenVector = v1._center - v0._center;
            float3 radiiVector = math.normalize(betweenVector) * (v0._radius + v1._radius);

            _center = (betweenVector + radiiVector) / 2.0f + v0._center;
            diameter = math.length(v0._center - v1._center) + v0._radius + v1._radius;
        }

        public void ExpandToFit (float3 other) {
            ConformTo(this, new boundsSphere(other, 0.0f));
        }

        public void ExpandToFit (boundsSphere other) {
            ConformTo(this, other);
        }

        public boundsSphere ExpandedToFit (boundsSphere other) {
            boundsSphere newBounds = this;
            newBounds.ExpandToFit(other);
            return newBounds;
        }

        public static boundsSphere FromCenterAndDiameter (float3 center, float diameter) {
            return new boundsSphere {
                _center = center,
                diameter = diameter
            };
        }

        public static boundsSphere FromCenterAndRadius (float3 center, float radius) {
            return new boundsSphere {
                _center = center,
                radius = radius
            };
        }

        public static boundsSphere FromPoints (float3 v0, float3 v1) {
            boundsSphere newBounds = new boundsSphere();
            newBounds.ConformTo(v0, v1);
            return newBounds;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals (boundsSphere other) {
            return _center.Equals(other._center) && _radius.Equals(other._radius);
        }

        public override bool Equals (object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bounds && Equals((bounds) obj);
        }

        public override int GetHashCode () {
            return (int)math.hash(_center) + _radius.GetHashCode();
        }
    }

    public struct boundsSphere_d : IEquatable<boundsSphere_d> {
        private double3 _center;
        public double3 center {
            get {
                return _center;
            }
            set {
                _center = value;
            }
        }

        private double _radius;
        public double radius {
            get {
                return _radius;
            }
            set {
                _radius = value;

                _diameter = 2.0 * _radius;
            }
        }

        private double _diameter;
        public double diameter {
            get {
                return _diameter;
            }
            set {
                _diameter = value;

                _radius = _diameter / 2.0;
            }
        }

        public boundsSphere_d (double3 center, double radius) {
            _center = center;
            _radius = radius;
            _diameter = 2.0 * radius;
        }

        public boundsSphere_d (boundsSphere bounds) {
            _center = bounds.center;
            _radius = bounds.radius;
            _diameter = 2.0 * _radius;
        }

        public void ConformTo (double3 v0, double3 v1) {
            _center = (v0 + v1) / 2.0f;
            diameter = math.length(v0 - v1);
        }

        public void ConformTo (boundsSphere_d v0, boundsSphere_d v1) {
            double3 betweenVector = v1._center - v0._center;
            double3 radiiVector = math.normalize(betweenVector) * (v0._radius + v1._radius);

            _center = (betweenVector + radiiVector) / 2.0f + v0._center;
            diameter = math.length(v0._center - v1._center) + v0._radius + v1._radius;
        }

        public void ExpandToFit (float3 other) {
            ConformTo(this, new boundsSphere_d(other, 0.0f));
        }

        public void ExpandToFit (boundsSphere_d other) {
            ConformTo(this, other);
        }

        public static implicit operator boundsSphere_d (boundsSphere bounds) {
            return new boundsSphere_d(bounds);
        }

        public bounds toboundsSphere () { // loss of precision should be explicit
            return new bounds(_center.toFloat3(), (float)_radius);
        }

        public static boundsSphere_d FromCenterAndDiameter (double3 center, double diameter) {
            return new boundsSphere_d {
                _center = center,
                diameter = diameter
            };
        }

        public static boundsSphere_d FromCenterAndExtents (double3 center, double radius) {
            return new boundsSphere_d {
                _center = center,
                radius = radius
            };
        }

        public static boundsSphere_d FromPoints (double3 v0, double3 v1) {
            boundsSphere_d newBounds = new boundsSphere_d();
            newBounds.ConformTo(v0, v1);
            return newBounds;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals (boundsSphere_d other) {
            return _center.Equals(other._center) && _radius.Equals(other._radius);
        }

        public override bool Equals (object obj) {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bounds_d && Equals((bounds_d) obj);
        }

        public override int GetHashCode () {
            return 17 * (int)math.hash(_center) + _radius.GetHashCode();
        }
    }

    public static partial class math_x {
        public static boundsSphere boundsSphere (float3 center, float radius) {
            return new boundsSphere(center, radius);
        }

        public static boundsSphere_d bounds_d (double3 center, double radius) {
            return new boundsSphere_d(center, radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool intersects (boundsSphere b0, boundsSphere b1) {
            return math.dot(b0.center, b1.center) < (b0.radius + b1.radius) * (b0.radius + b1.radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool intersects (boundsSphere_d b0, boundsSphere_d b1) {
            return math.dot(b0.center, b1.center) < (b0.radius + b1.radius) * (b0.radius + b1.radius);
        }
    }
}
