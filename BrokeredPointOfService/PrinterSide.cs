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