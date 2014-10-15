using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates possible placements for the readable character string of a bar
    //     code.
    public sealed class BarCodeTextPosition : Enumeration
    {

        internal Microsoft.PointOfService.BarCodeTextPosition InternalBarCodeTextPosition;

        internal BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition barCodeTextPosition)
        {
            InternalBarCodeTextPosition = barCodeTextPosition;
        }

        // Summary:
        //     Indicates to print the text below the bar code.
        public static BarCodeTextPosition Below
        {
            get
            {
                return new BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition.Below);
            }
        }

        //
        // Summary:
        //     Indicates to print the text above the bar code.
        public static BarCodeTextPosition Above
        {
            get
            {
                return new BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition.Above);
            }
        }

        //
        // Summary:
        //     Indicates that no text is printed. Only prints the bar code.
        public static BarCodeTextPosition None
        {
            get
            {
                return new BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition.None);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            BarCodeTextPosition other = (BarCodeTextPosition)obj;
            return this.InternalBarCodeTextPosition.Equals(other.InternalBarCodeTextPosition);
        }

        public override int GetHashCode()
        {
            return InternalBarCodeTextPosition.GetHashCode();
        }

        public override string ToString()
        {
            return InternalBarCodeTextPosition.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalBarCodeTextPosition;
            }
        }
    }
}
