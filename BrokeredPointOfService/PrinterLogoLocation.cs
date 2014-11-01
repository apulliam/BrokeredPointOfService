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