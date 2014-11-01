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
    //     Defines the programmatic interface for the transmission of Data Events.
    [System.Runtime.InteropServices.ComVisible(true)]
    public sealed class DataEventArgs : PosEventArgs
    {
        internal Microsoft.PointOfService.DataEventArgs InternalDataEventArgs { get; set; }

        internal DataEventArgs(Microsoft.PointOfService.DataEventArgs dataEventArgs)
        {
            InternalDataEventArgs = dataEventArgs;
        }

        // Summary:
        //     Gets the event identifier.
        public int EventId
        {
            get
            {
                return InternalDataEventArgs.EventId;
            }
        }

        //
        // Summary:
        //     Gets the DateTime of the event.
        public DateTimeOffset TimeStamp
        {
            get
            {
                return new DateTimeOffset(InternalDataEventArgs.TimeStamp);
            }
        }

        // Summary:
        //     Gets the integer value for the device input status.
        public int Status 
        {
            get
            {
                return InternalDataEventArgs.Status;
            }
        }

        // Summary:
        //     Sets the device input status.
        //
        // Parameters:
        //   status:
        //     The device input status value to set.
        //protected int SetStatus(int status)
        //{
        //    InternalDataEventArgs.Status = status;
        //}

        //
        // Summary:
        //     Returns a string that represents the input status.
        //public override string ToString()
        //{
        //}
    }
}
