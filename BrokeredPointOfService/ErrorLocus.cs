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
    //     Enumerates possible times when an error occurred.
    public sealed class ErrorLocus : Enumeration
    {
        internal Microsoft.PointOfService.ErrorLocus InternalErrorLocus { get; set; }

        internal ErrorLocus(Microsoft.PointOfService.ErrorLocus errorLocus)
        {
            InternalErrorLocus = errorLocus;
        }
        
        // Summary:
        //     An error occurred while processing asynchronous output.
        public static ErrorLocus Output
        {
            get
            {
                return new ErrorLocus(Microsoft.PointOfService.ErrorLocus.Output);
            }
        }
        
        //
        // Summary:
        //     Error occurred while gathering or processing event-driven input. No input
        //     data is available.
        public static ErrorLocus Input
        {
            get
            {
                return new ErrorLocus(Microsoft.PointOfService.ErrorLocus.Input);
            }
        }

        //
        // Summary:
        //     An error occurred while gathering or processing event-driven input, and some
        //     previously buffered data is available.
        public static ErrorLocus InputData
        {
            get
            {
                return new ErrorLocus(Microsoft.PointOfService.ErrorLocus.InputData);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ErrorLocus other = (ErrorLocus)obj;
            return this.InternalErrorLocus.Equals(other.InternalErrorLocus);
        }

        public override int GetHashCode()
        {
            return InternalErrorLocus.GetHashCode();
        }

        public override string ToString()
        {
            return InternalErrorLocus.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalErrorLocus;
            }
        }
    }
}
