using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Lists the possible bitmap and bar code rotations for printing.
    public sealed class Rotation : Enumeration
    {
        internal Microsoft.PointOfService.Rotation InternalRotation;

        internal Rotation(Microsoft.PointOfService.Rotation rotation)
        {
            InternalRotation = rotation;
        }

        // Summary:
        //     End rotated printing.
        public static Rotation Normal
        {
            get
            {
                return new Rotation(Microsoft.PointOfService.Rotation.Normal);
            }
        }

        //
        // Summary:
        //     Start rotated printing 90° to the right (clockwise).
        public static Rotation Right90
        {
            get
            {
                return new Rotation(Microsoft.PointOfService.Rotation.Right90);
            }
        }

        //
        // Summary:
        //     Start rotated printing 90° to the left (counter-clockwise).
        public static Rotation Left90
        {
            get
            {
                return new Rotation(Microsoft.PointOfService.Rotation.Left90);
            }
        }

        //
        // Summary:
        //     Start rotated printing 180° (that is, print upside-down).
        public static Rotation Rotate180
        {
            get
            {
                return new Rotation(Microsoft.PointOfService.Rotation.Rotate180);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Rotation other = (Rotation)obj;
            return this.InternalRotation.Equals(other.InternalRotation);
        }

        public override int GetHashCode()
        {
            return InternalRotation.GetHashCode();
        }

        public override string ToString()
        {
            return InternalRotation.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalRotation;
            }
        }

    }
}
