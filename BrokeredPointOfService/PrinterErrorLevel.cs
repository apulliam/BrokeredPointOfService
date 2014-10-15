using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible severity levels for the most recent error condition.
    public sealed class PrinterErrorLevel : Enumeration
    {
        internal Microsoft.PointOfService.PrinterErrorLevel InternalPrinterErrorLevel;

        internal PrinterErrorLevel(Microsoft.PointOfService.PrinterErrorLevel printerErrorLevel)
        {
            InternalPrinterErrorLevel = printerErrorLevel;
        }

        // Summary:
        //     No errors have occurred.
        public static PrinterErrorLevel None
        {
            get
            {
                return new PrinterErrorLevel(Microsoft.PointOfService.PrinterErrorLevel.None);
            }
        }

        //
        // Summary:
        //     A recoverable error has occurred. (For example, out of paper.)
        public static PrinterErrorLevel Recoverable
        {
            get
            {
                return new PrinterErrorLevel(Microsoft.PointOfService.PrinterErrorLevel.Recoverable);
            }
        }

        //
        // Summary:
        //     A nonrecoverable error has occurred. (For example, internal printer failure.)
        public static PrinterErrorLevel Fatal
        {
            get
            {
                return new PrinterErrorLevel(Microsoft.PointOfService.PrinterErrorLevel.Fatal);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterErrorLevel other = (PrinterErrorLevel)obj;
            return this.InternalPrinterErrorLevel.Equals(other.InternalPrinterErrorLevel);
        }

        public override int GetHashCode()
        {
            return InternalPrinterErrorLevel.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrinterErrorLevel.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterErrorLevel;
            }
        }

    }
}