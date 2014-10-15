using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible transaction modes for a printer station.
    public sealed class PrinterTransactionControl : Enumeration
    {
        internal Microsoft.PointOfService.PrinterTransactionControl InternalPrinterTransactionControl;

        internal PrinterTransactionControl(Microsoft.PointOfService.PrinterTransactionControl printerTransactionControl)
        {
            InternalPrinterTransactionControl = printerTransactionControl;
        }

        // Summary:
        //     Starts a transaction.
        public static PrinterTransactionControl Transaction
        {
            get
            {
                return new PrinterTransactionControl(Microsoft.PointOfService.PrinterTransactionControl.Transaction);
            }
        }

        //
        // Summary:
        //     Ends a transaction by printing the buffered data.
        public static PrinterTransactionControl Normal
        {
            get
            {
                return new PrinterTransactionControl(Microsoft.PointOfService.PrinterTransactionControl.Normal);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterTransactionControl other = (PrinterTransactionControl)obj;
            return this.InternalPrinterTransactionControl.Equals(other.InternalPrinterTransactionControl);
        }

        public override int GetHashCode()
        {
            return InternalPrinterTransactionControl.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrinterTransactionControl.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterTransactionControl;
            }
        }

    }
}