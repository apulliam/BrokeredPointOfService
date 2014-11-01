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
    // Summary:
    //     Lists the error reporting types for an MSR device.
    public sealed class MsrErrorReporting : Enumeration
    {
        internal Microsoft.PointOfService.MsrErrorReporting InternalMsrErrorReporting { get; set; }

        internal MsrErrorReporting(Microsoft.PointOfService.MsrErrorReporting msrErrorReporting)
        {
            this.InternalMsrErrorReporting = msrErrorReporting;
        }

        // Summary:
        //     Report errors at a card level.
        public static MsrErrorReporting Card
        {
            get
            {
                return new MsrErrorReporting(Microsoft.PointOfService.MsrErrorReporting.Card);
            }
        }

        //
        // Summary:
        //     Report errors at a track level.
        public static MsrErrorReporting Track
        {
            get
            {
                return new MsrErrorReporting(Microsoft.PointOfService.MsrErrorReporting.Track);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MsrErrorReporting other = (MsrErrorReporting)obj;
            return this.InternalMsrErrorReporting.Equals(other.InternalMsrErrorReporting);
        }

        public override int GetHashCode()
        {
            return InternalMsrErrorReporting.GetHashCode();
        }

        public override string ToString()
        {
            return InternalMsrErrorReporting.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalMsrErrorReporting;
            }
        }
    }
}
