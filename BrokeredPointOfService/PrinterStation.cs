using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible printer station modes.
    public sealed class PrinterStation : Enumeration
    {
        internal Microsoft.PointOfService.PrinterStation InternalPrinterStation;

        internal PrinterStation(Microsoft.PointOfService.PrinterStation printerStation)
        {
            InternalPrinterStation = printerStation;
        }

        // Summary:
        //     The current printer station is undefined.
        public static PrinterStation None
        {
            get
            {
                return new PrinterStation(Microsoft.PointOfService.PrinterStation.None);
            }
        }

        //
        // Summary:
        //     The current printer station is Journal.
        public static PrinterStation Journal
        {
            get
            {
                return new PrinterStation(Microsoft.PointOfService.PrinterStation.Journal);
            }
        }

        //
        // Summary:
        //     The current printer station is Receipt.
        public static PrinterStation Receipt
        {
            get
            {
                return new PrinterStation(Microsoft.PointOfService.PrinterStation.Receipt);
            }
        }

        //
        // Summary:
        //     The current printer station is Slip.
        public static PrinterStation Slip
        {
            get
            {
                return new PrinterStation(Microsoft.PointOfService.PrinterStation.Slip);
            }
        }

        //
        // Summary:
        //     The current printer station combines Receipt and Journal.
        public static PrinterStation TwoReceiptJournal
        {
            get
            {
                return new PrinterStation(Microsoft.PointOfService.PrinterStation.TwoReceiptJournal);
            }
        }

        //
        // Summary:
        //     The current printer station combines Slip and Journal.
        public static PrinterStation TwoSlipJournal
        {
            get
            {
                return new PrinterStation(Microsoft.PointOfService.PrinterStation.TwoSlipJournal);
            }
        }

        //
        // Summary:
        //     The current printer station combines Receipt and Slip.
        public static PrinterStation TwoSlipReceipt
        {
            get
            {
                return new PrinterStation(Microsoft.PointOfService.PrinterStation.TwoSlipReceipt);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterStation other = (PrinterStation)obj;
            return this.InternalPrinterStation.Equals(other.InternalPrinterStation);
        }

        public override int GetHashCode()
        {
            return InternalPrinterStation.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrinterStation.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterStation;
            }
        }
    }
}
