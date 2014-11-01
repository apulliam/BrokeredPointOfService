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
    //     Lists the possible print directions that can be set for a print station.
    public sealed class PageModePrintDirection : Enumeration
    {
        internal Microsoft.PointOfService.PageModePrintDirection InternalPageModePrintDirection { get; set; }

        internal PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection pageModePrintDirection)
        {
            InternalPageModePrintDirection = pageModePrintDirection;
        }

        // Summary:
        //     No valid station is selected.
        public static PageModePrintDirection None
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.None);
            }
        }

        //
        // Summary:
        //     Print left to right, starting at top left position of the print area (that
        //     is, normal printing).
        public static PageModePrintDirection LeftToRight
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.LeftToRight);
            }
        }

        //
        // Summary:
        //     Print bottom to top, starting at the bottom left position of the print area
        //     (that is, rotated left 90° printing).
        public static PageModePrintDirection BottomToTop
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.BottomToTop);
            }
        }

        //
        // Summary:
        //     Print right to left, starting at the bottom right position of the print area
        //     (that is, upside down printing).
        public static PageModePrintDirection RightToLeft
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.RightToLeft);
            }
        }

        //
        // Summary:
        //     Print top to bottom, starting at the top right position of the print area
        //     (that is, rotated right 90° printing.)
        public static PageModePrintDirection TopToBottom
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.TopToBottom);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PageModePrintDirection other = (PageModePrintDirection)obj;
            return this.InternalPageModePrintDirection.Equals(other.InternalPageModePrintDirection);
        }

        public override int GetHashCode()
        {
            return InternalPageModePrintDirection.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPageModePrintDirection.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPageModePrintDirection;
            }
        }
    }
}