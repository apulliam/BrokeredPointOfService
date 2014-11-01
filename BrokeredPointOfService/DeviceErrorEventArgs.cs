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
    //     Defines the programmatic interface for the transmission of Device Error Events.
    public sealed class DeviceErrorEventArgs : PosEventArgs
    {
        internal Microsoft.PointOfService.DeviceErrorEventArgs InternalDeviceErrorEventArgs { get; set; }
     
        internal DeviceErrorEventArgs(Microsoft.PointOfService.DeviceErrorEventArgs deviceErrorEventArgs) 
        {
            InternalDeviceErrorEventArgs = deviceErrorEventArgs;
        }

        // Summary:
        //     Gets the event identifier.
        public int EventId
        {
            get
            {
                return InternalDeviceErrorEventArgs.EventId;
            }
        }

        //
        // Summary:
        //     Gets the DateTime of the event.
        public DateTimeOffset TimeStamp
        {
            get
            {
                return new DateTimeOffset(InternalDeviceErrorEventArgs.TimeStamp);
            }
        }

        public ErrorCode ErrorCode 
        {
            get
            {
                return new ErrorCode(InternalDeviceErrorEventArgs.ErrorCode);
                //return (ErrorCode)InternalDeviceErrorEventArgs.ErrorCode;
            }
        }
        public int ErrorCodeExtended 
        {
            get
            {
                return InternalDeviceErrorEventArgs.ErrorCodeExtended;
            }
        }
        public ErrorLocus ErrorLocus 
        {
            get
            {
                return new ErrorLocus(InternalDeviceErrorEventArgs.ErrorLocus);
                //return (ErrorLocus)InternalDeviceErrorEventArgs.ErrorLocus;

            }
        }
        public ErrorResponse ErrorResponse 
        {
            get
            {
                return new ErrorResponse(InternalDeviceErrorEventArgs.ErrorResponse);
                //return (ErrorResponse)InternalDeviceErrorEventArgs.ErrorResponse;
            }
            set
            {
                InternalDeviceErrorEventArgs.ErrorResponse =  value.InternalErrorResponse;
                //InternalDeviceErrorEventArgs.ErrorResponse = (Microsoft.PointOfService.ErrorResponse)value;
            }
        }

        public override string ToString()
        {
            return InternalDeviceErrorEventArgs.ToString();
        }
    }
}
