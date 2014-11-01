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