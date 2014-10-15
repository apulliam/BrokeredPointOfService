using System;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates possible sides of the print station document on which printing
    //     can occur.
    public sealed class PrinterSide : Enumeration
    {
        internal Microsoft.PointOfService.PrinterSide InternalPrinterSide;

        internal PrinterSide(Microsoft.PointOfService.PrinterSide printerSide)
        {
            InternalPrinterSide = printerSide;
        }

        // Summary:
        //     Document is not inserted.
        public static PrinterSide Unknown
        {
            get
            {
                return new PrinterSide(Microsoft.PointOfService.PrinterSide.Unknown);
            }
        }

        //
        // Summary:
        //     Default print side.
        public static PrinterSide Side1
        {
            get
            {
                return new PrinterSide(Microsoft.PointOfService.PrinterSide.Side1);
            }
        }

        //
        // Summary:
        //     The other side of the document (the reverse of default).
        public static PrinterSide Side2
        {
            get
            {
                return new PrinterSide(Microsoft.PointOfService.PrinterSide.Side2);
            }
        }

        //
        // Summary:
        //     The opposite of the current side.
        public static PrinterSide Opposite
        {
            get
            {
                return new PrinterSide(Microsoft.PointOfService.PrinterSide.Opposite);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterSide other = (PrinterSide)obj;
            return this.InternalPrinterSide.Equals(other.InternalPrinterSide);
        }

        public override int GetHashCode()
        {
            return InternalPrinterSide.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrinterSide.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterSide;
            }
        }

    }
}