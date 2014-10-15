using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible locations for setting a logo.
    public sealed class PrinterLogoLocation : Enumeration
    {
        internal Microsoft.PointOfService.PrinterLogoLocation InternalPrinterLogoLocation;

        internal PrinterLogoLocation(Microsoft.PointOfService.PrinterLogoLocation printerLogoLocation)
        {
            InternalPrinterLogoLocation = printerLogoLocation;
        }

        // Summary:
        //     Puts the logo at the top of the document.
        public static PrinterLogoLocation Top
        {
            get
            {
                return new PrinterLogoLocation(Microsoft.PointOfService.PrinterLogoLocation.Top);
            }
        }

        //
        // Summary:
        //     Puts the logo at the bottom of the document.
        public static PrinterLogoLocation Bottom
        {
            get
            {
                return new PrinterLogoLocation(Microsoft.PointOfService.PrinterLogoLocation.Bottom);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterLogoLocation other = (PrinterLogoLocation)obj;
            return this.InternalPrinterLogoLocation.Equals(other.InternalPrinterLogoLocation);
        }

        public override int GetHashCode()
        {
            return InternalPrinterLogoLocation.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrinterLogoLocation.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterLogoLocation;
            }
        }

    }
}