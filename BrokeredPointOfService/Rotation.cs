// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
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
