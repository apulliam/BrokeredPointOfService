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
    //     Lists the valid Page Mode controls for a print station.
    public sealed class PageModePrintControl : Enumeration
    {
        internal Microsoft.PointOfService.PageModePrintControl InternalPageModePrintControl;

        internal PageModePrintControl(Microsoft.PointOfService.PageModePrintControl pageModePrintControl)
        {
            InternalPageModePrintControl = pageModePrintControl;
        }

        // Summary:
        //     Enter Page Mode.
        public static PageModePrintControl PageMode
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.PageMode);
            }
        }

        //
        // Summary:
        //     Print PageModePrintArea and save the canvas. Page Mode is not exited. Use
        //     for printing of repeated pages.
        public static PageModePrintControl PrintSave
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.PrintSave);
            }
        }

        //
        // Summary:
        //     Print the print area and destroy the canvas and exit Page Mode.
        public static PageModePrintControl Normal
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.Normal);
            }
        }

        //
        // Summary:
        //     Clear the page and exit the Page Mode without any printing of any print area.
        public static PageModePrintControl Cancel
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.Cancel);
            }
        }


         public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PageModePrintControl other = (PageModePrintControl)obj;
            return this.InternalPageModePrintControl.Equals(other.InternalPageModePrintControl);
        }

        public override int GetHashCode()
        {
            return InternalPageModePrintControl.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPageModePrintControl.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPageModePrintControl;
            }
        }
    }
}