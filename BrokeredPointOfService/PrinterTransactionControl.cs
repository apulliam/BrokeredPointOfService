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