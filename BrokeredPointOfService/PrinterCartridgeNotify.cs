// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
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
