using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible rotation settings for a printer device.
    public sealed class PrintRotation : Enumeration
    {
        internal Microsoft.PointOfService.PrintRotation InternalPrintRotation { get; set; }

        internal PrintRotation(Microsoft.PointOfService.PrintRotation printRotation)
        {
            InternalPrintRotation = printRotation;
        }

        // Summary:
        //     Ends rotated printing.
        public static PrintRotation Normal
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Normal);
            }
        }

        //
        // Summary:
        //     Rotates printing 90 degrees to the right side (clockwise).
        public static PrintRotation Right90
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Right90);
            }
        }

        //
        // Summary:
        //     Rotates printing 90 degrees to the left (counter-clockwise).
        public static PrintRotation Left90
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Left90);
            }
        }

        //
        // Summary:
        //     Rotates printing 180 degrees (print upside-down).
        public static PrintRotation Rotate180
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Rotate180);
            }
        }

        //
        // Summary:
        //     Rotates bar code printing. (ORed with one of the previous rotation values.)
        public static PrintRotation BarcodeNormal
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Normal |
                                         Microsoft.PointOfService.PrintRotation.Barcode);
            }
        }

        public static PrintRotation BarcodeRight90
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Barcode|
                                         Microsoft.PointOfService.PrintRotation.Right90);
            }
        }

        public static PrintRotation BarcodeLeft90
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Barcode|
                                         Microsoft.PointOfService.PrintRotation.Left90);
            }
        }

        public static PrintRotation BarcodeRotate180
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Barcode |
                                         Microsoft.PointOfService.PrintRotation.Rotate180);
            }
        }

        //
        // Summary:
        //     Rotates bitmap printing. (ORed with one of the previous rotation values.)
        public static PrintRotation BitmapNormal
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Bitmap |
                                         Microsoft.PointOfService.PrintRotation.Normal);
            }
        }

        public static PrintRotation BitmapRight90
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Bitmap |
                                         Microsoft.PointOfService.PrintRotation.Right90);
            }
        }

        public static PrintRotation BitmapLeft90
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Bitmap |
                                         Microsoft.PointOfService.PrintRotation.Left90);
            }
        }

        public static PrintRotation BitmapRotate180
        {
            get
            {
                return new PrintRotation(Microsoft.PointOfService.PrintRotation.Rotate180 |
                                         Microsoft.PointOfService.PrintRotation.Bitmap);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrintRotation other = (PrintRotation)obj;
            return this.InternalPrintRotation.Equals(other.InternalPrintRotation);
        }

        public override int GetHashCode()
        {
            return InternalPrintRotation.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrintRotation.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrintRotation;
            }
        }

    }
}