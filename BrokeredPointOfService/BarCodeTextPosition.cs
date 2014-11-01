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
    //     Enumerates possible placements for the readable character string of a bar
    //     code.
    public sealed class BarCodeTextPosition : Enumeration
    {

        internal Microsoft.PointOfService.BarCodeTextPosition InternalBarCodeTextPosition;

        internal BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition barCodeTextPosition)
        {
            InternalBarCodeTextPosition = barCodeTextPosition;
        }

        // Summary:
        //     Indicates to print the text below the bar code.
        public static BarCodeTextPosition Below
        {
            get
            {
                return new BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition.Below);
            }
        }

        //
        // Summary:
        //     Indicates to print the text above the bar code.
        public static BarCodeTextPosition Above
        {
            get
            {
                return new BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition.Above);
            }
        }

        //
        // Summary:
        //     Indicates that no text is printed. Only prints the bar code.
        public static BarCodeTextPosition None
        {
            get
            {
                return new BarCodeTextPosition(Microsoft.PointOfService.BarCodeTextPosition.None);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            BarCodeTextPosition other = (BarCodeTextPosition)obj;
            return this.InternalBarCodeTextPosition.Equals(other.InternalBarCodeTextPosition);
        }

        public override int GetHashCode()
        {
            return InternalBarCodeTextPosition.GetHashCode();
        }

        public override string ToString()
        {
            return InternalBarCodeTextPosition.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalBarCodeTextPosition;
            }
        }
    }
}
