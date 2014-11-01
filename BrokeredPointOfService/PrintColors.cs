// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    //   [Flags]
    //public enum PrinterColors
    //{
    //    // Summary:
    //    //     Supports full color.
    //    Full = -2147483648,
    //    //
    //    // Summary:
    //    //     Supports no color.
    //    None = 0,
    //    //
    //    // Summary:
    //    //     Supports primary color.
    //    Primary = 1,
    //    //
    //    // Summary:
    //    //     Supports first custom color (Secondary color, usually red).
    //    Custom1 = 2,
    //    //
    //    // Summary:
    //    //     Supports second custom color.
    //    Custom2 = 4,
    //    //
    //    // Summary:
    //    //     Supports third custom color.
    //    Custom3 = 8,
    //    //
    //    // Summary:
    //    //     Supports fourth custom color.
    //    Custom4 = 16,
    //    //
    //    // Summary:
    //    //     Supports fifth custom color.
    //    Custom5 = 32,
    //    //
    //    // Summary:
    //    //     Supports sixth custom color.
    //    Custom6 = 64,
    //    //
    //    // Summary:
    //    //     Supports cyan color for full color printing.
    //    Cyan = 256,
    //    //
    //    // Summary:
    //    //     Supports magenta color for full color printing.
    //    Magenta = 512,
    //    //
    //    // Summary:
    //    //     Supports yellow color for full color printing.
    //    Yellow = 1024,

    // ToDo: Fill in bitwise OR values


    // Summary:
    //     Enumerates the possible printer color cartridges.
    public sealed class PrinterColors : Enumeration
    {
        internal Microsoft.PointOfService.PrinterColors InternalPrintColors;

        internal PrinterColors(Microsoft.PointOfService.PrinterColors printColors)
        {
            InternalPrintColors = printColors;
        }

        // Summary:
        //     Supports full color.
        public static PrinterColors Full
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Full);
            }
        }

        //
        // Summary:
        //     Supports no color.
        public static PrinterColors None
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.None);
            }
        }

        //
        // Summary:
        //     Supports primary color.
        public static PrinterColors Primary
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Primary);
            }
        }

        //
        // Summary:
        //     Supports first custom color (Secondary color, usually red).
        public static PrinterColors Custom1
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Custom1);
            }
        }

        //
        // Summary:
        //     Supports second custom color.
        public static PrinterColors Custom2
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Custom2);
            }
        }

        //
        // Summary:
        //     Supports third custom color.
        public static PrinterColors Custom3
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Custom3);
            }
        }

        //
        // Summary:
        //     Supports fourth custom color.
        public static PrinterColors Custom4
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Custom4);
            }
        }

        //
        // Summary:
        //     Supports fifth custom color.
        public static PrinterColors Custom5
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Custom5);
            }
        }

        //
        // Summary:
        //     Supports sixth custom color.
        public static PrinterColors Custom6
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Custom6);
            }
        }

        //
        // Summary:
        //     Supports cyan color for full color printing.
        public static PrinterColors Cyan
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Cyan);
            }
        }

        //
        // Summary:
        //     Supports magenta color for full color printing.
        public static PrinterColors Magenta
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Magenta);
            }
        }

        //
        // Summary:
        //     Supports yellow color for full color printing.
        public static PrinterColors Yellow
        {
            get
            {
                return new PrinterColors(Microsoft.PointOfService.PrinterColors.Yellow);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterColors other = (PrinterColors)obj;
            return this.InternalPrintColors.Equals(other.InternalPrintColors);
        }
        public override int GetHashCode()
        {
            return InternalPrintColors.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrintColors.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrintColors;
            }
        }

    }
}
