using System.Runtime.CompilerServices;
using static Unity.Mathematics.math;

namespace Unity.Mathematics
{
    public struct bounds
    {
        private float3 _center;
        public float3 center {
            get {
                return _center;
            }
            set {
                _center = value;

                _min = _center - _extents;
                _max = _center + _extents;
            }
        }

        private float3 _extents;
        public float3 extents {
            get {
                return _extents;
            }
            set {
                _extents = value;

                _size = 2.0f * _extents;

                _min = _center - _extents;
                _max = _center + _extents;
            }
        }

        private float3 _size;
        public float3 size {
            get {
                return _size;
            }
            set {
                _size = value;

                _extents = _size / 2.0f;

                _min = _center - _extents;
                _max = _center + _extents;
            }
        }

        private float3 _min;
        public float3 min {
            get {
                return _min;
            }
        }

        private float3 _max;
        public float3 max {
            get {
                return _max;
            }
        }

        public bounds(float3 center, float3 extents) {
            _center = center;
            _extents = extents;
            _size = 2.0f * _extents;
            _min = _center - _extents;
            _max = _center + _extents;
        }

        public bounds(bounds_d bounds) {
            _center = bounds.center.toFloat3();
            _extents = bounds.extents.toFloat3();
            _size = 2.0f * _extents;
            _min = _center - _extents;
            _max = _center + _extents;
        }

        public void ConformTo (float3 v0, float3 v1) {
            _center = (v0 + v1) / 2.0f;
            size = max(v0, v1) - min(v0, v1);
        }

        public void ExpandToFit(bounds other) {
            ConformTo(min(_min, other.min), min(_max, other.max));
        }

        public bounds ExpandedToFit (bounds other) {
            bounds newBounds = this;
            newBounds.ExpandToFit(other);
            return newBounds;
        }

        public static bounds FromCenterAndSize (float3 center, float3 size) {
            return new bounds {
                _center = center,
                size = size
            };
        }

        public static bounds FromCenterAndExtents (float3 center, float3 extents) {
            return new bounds {
                _center = center,
                extents = extents
            };
        }

        public static bounds FromPoints (float3 v0, float3 v1) {
            bounds newBounds = new bounds();
            newBounds.ConformTo(v0, v1);
            return newBounds;
        }
    }

    public struct bounds_d
    {
        private double3 _center;
        public double3 center {
            get {
                return _center;
            }
            set {
                _center = value;

                _min = _center - _extents;
                _max = _center + _extents;
            }
        }

        private double3 _extents;
        public double3 extents {
            get {
                return _extents;
            }
            set {
                _extents = value;

                _size = 2.0 * _extents;

                _min = _center - _extents;
                _max = _center + _extents;
            }
        }

        private double3 _size;
        public double3 size {
            get {
                return _size;
            }
            set {
                _size = value;

                _extents = _size / 2.0;

                _min = _center - _extents;
                _max = _center + _extents;
            }
        }

        private double3 _min;
        public double3 min {
            get {
                return _min;
            }
        }

        private double3 _max;
        public double3 max {
            get {
                return _max;
            }
        }

        public bounds_d(double3 center, double3 extents) {
            _center = center;
            _extents = extents;
            _size = 2.0 * _extents;
            _min = _center - _extents;
            _max = _center + _extents;
        }

        public bounds_d(bounds bounds) {
            _center = bounds.center;
            _extents = bounds.extents;
            _size = 2.0 * _extents;
            _min = _center - _extents;
            _max = _center + _extents;
        }

        public void ConformTo(double3 v0, double3 v1) {
            _center = (v0 + v1) / 2.0;
            size = max(v0, v1) - min(v0, v1);
        }

        public void ExpandToFit(bounds_d other) {
            ConformTo(min(_min, other.min), min(_max, other.max));
        }

        public bounds_d ExpandedToFit (bounds_d other) {
            bounds_d newBoundsD = this;
            newBoundsD.ExpandToFit(other);
            return newBoundsD;
        }

        public static implicit operator bounds_d (bounds bounds) {
            return new bounds_d(bounds);
        }

        public bounds toBounds()
        {
            return new bounds(this);
        }

        public static bounds_d FromCenterAndSize (double3 center, double3 size) {
            return new bounds_d {
                _center = center,
                size = size
            };
        }

        public static bounds_d FromCenterAndExtents (double3 center, double3 extents) {
            return new bounds_d {
                _center = center,
                extents = extents
            };
        }

        public static bounds_d FromPoints (double3 v0, double3 v1) {
            bounds_d newBounds = new bounds_d();
            newBounds.ConformTo(v0, v1);
            return newBounds;
        }
    }

    public static partial class math
    {
        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool intersects (bounds b0, bounds b1) {
            return b0.max.x > b1.min.x
                   && b0.min.x < b1.max.x
                   && b0.max.y > b1.min.y
                   && b0.min.y < b1.max.y
                   && b0.max.z > b1.min.z
                   && b0.min.z < b1.max.z;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool intersects (bounds_d b0, bounds_d b1) {
            return b0.max.x > b1.min.x
                   && b0.min.x < b1.max.x
                   && b0.max.y > b1.min.y
                   && b0.min.y < b1.max.y
                   && b0.max.z > b1.min.z
                   && b0.min.z < b1.max.z;
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool equal(bounds b0, bounds b1)
        {
            return all(equal(b0.center, b1.center) & equal(b0.extents, b1.extents));
        }

        [MethodImpl((MethodImplOptions)0x100)] // agressive inline
        public static bool equal(bounds_d b0, bounds_d b1)
        {
            return all(equal(b0.center, b1.center) & equal(b0.extents, b1.extents));
        }
    }
}
