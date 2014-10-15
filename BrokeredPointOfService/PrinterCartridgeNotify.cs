using System;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible cartridge-state notification capabilities for a printer.
    public sealed class PrinterCartridgeNotify : Enumeration
    {
        internal Microsoft.PointOfService.PrinterCartridgeNotify InternalPrinterCartridgeNotify;

        internal PrinterCartridgeNotify(Microsoft.PointOfService.PrinterCartridgeNotify printerCartridgeNotify)
        {
            InternalPrinterCartridgeNotify = printerCartridgeNotify;
        }

        // Summary:
        //     Cartridge-state notifications are not available.
        public static PrinterCartridgeNotify Disabled
        {
            get
            {
                return new PrinterCartridgeNotify(Microsoft.PointOfService.PrinterCartridgeNotify.Disabled);
            }
        }
    
        //
        // Summary:
        //     Cartridge-state notifications are available.
        public static PrinterCartridgeNotify Enabled
        {
            get
            {
                return new PrinterCartridgeNotify(Microsoft.PointOfService.PrinterCartridgeNotify.Enabled);
            }
        }
    
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterCartridgeNotify other = (PrinterCartridgeNotify)obj;
            return this.InternalPrinterCartridgeNotify.Equals(other.InternalPrinterCartridgeNotify);
        }

        public override int GetHashCode()
        {
            return InternalPrinterCartridgeNotify.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPrinterCartridgeNotify.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterCartridgeNotify;
            }
        }
    }
}
