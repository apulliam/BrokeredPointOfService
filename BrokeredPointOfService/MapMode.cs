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
    //     Lists the valid units of measure for Printer, Check Scanner, and Point Card
    //     Reader Writer devices.
    public sealed class MapMode : Enumeration
    {
        internal Microsoft.PointOfService.MapMode InternalMapMode;

        internal MapMode(Microsoft.PointOfService.MapMode mapMode)
        {
            InternalMapMode = mapMode;
        }

        // Summary:
        //     The device's dot width.
        public static MapMode Dots 
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.Dots);
            }
        }

        //
        // Summary:
        //     1/1440 of an inch
        public static MapMode Twips 
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.Twips);
            }
        }

        //
        // Summary:
        //     0.001 inch
        public static MapMode English 
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.English);
            }
        }

        //
        // Summary:
        //     0.01 millimeter
        public static MapMode Metric
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.Metric);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MapMode other = (MapMode)obj;
            return this.InternalMapMode.Equals(other.InternalMapMode);
        }

        public override int GetHashCode()
        {
            return InternalMapMode.GetHashCode();
        }

        public override string ToString()
        {
            return InternalMapMode.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalMapMode;
            }
        }
    }
}
