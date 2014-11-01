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
    //     Enumerates the valid types of errors for an error event.
    public sealed class ErrorCode : Enumeration
    {
        internal Microsoft.PointOfService.ErrorCode InternalErrorCode { get; set; }

        internal ErrorCode(Microsoft.PointOfService.ErrorCode errorCode)
        {
            InternalErrorCode = errorCode;
        }

        // Summary:
        //     No error occurred.
        public static ErrorCode Success
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Success);
            }
        }

        //
        // Summary:
        //     The device must be opened.
        public static ErrorCode Closed
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Closed);
            }
        }

        //
        // Summary:
        //     The device is opened but not claimed. Another application has the device
        //     claimed, so it cannot be claimed at this time.
        public static ErrorCode Claimed
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Claimed);
            }
        }

        //
        // Summary:
        //     The device is opened but not claimed. No other application has the device
        //     claimed, so it can and must be claimed.
        public static ErrorCode NotClaimed
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.NotClaimed);
            }
        }

        //
        // Summary:
        //     The control cannot communicate with the service object, normally because
        //     of a setup or configuration error.
        public static ErrorCode NoService
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.NoService);
            }
        }

        //
        // Summary:
        //     The device is opened and claimed (if this is an exclusive use device), but
        //     not enabled.
        public static ErrorCode Disabled
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Disabled);
            }
        }

        //
        // Summary:
        //     An attempt was made to perform an illegal or unsupported operation with the
        //     device, or an invalid parameter value was used.
        public static ErrorCode Illegal
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Illegal);
            }
        }

        //
        // Summary:
        //     The physical device is not connected to the system or is not powered on.
        public static ErrorCode NoHardware
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.NoHardware);
            }
        }

        //
        // Summary:
        //     The physical device is off-line.
        public static ErrorCode Offline
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Offline);
            }
        }

        //
        // Summary:
        //     The file name (or other specified value) does not exist.
        public static ErrorCode NoExist
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.NoExist);
            }
        }

        //
        // Summary:
        //     The file name (or other specified value) already exists.
        public static ErrorCode Exists
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Exists);
            }
        }

        //
        // Summary:
        //     The device cannot perform the requested procedure, even though the physical
        //     device is connected to the system, powered on, and on-line.
        public static ErrorCode Failure
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Failure);
            }
        }

        //
        // Summary:
        //     The service object timed out waiting for a response from the physical device,
        //     or the control timed out waiting for a response from the service object.
        public static ErrorCode Timeout
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Timeout);
            }
        }

        //
        // Summary:
        //     The current state does not allow this request. For example: if asynchronous
        //     output is in progress, certain methods may not be allowed.
        public static ErrorCode Busy
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Busy);
            }
        }

        //
        // Summary:
        //     A device category-specific error condition occurred. The error condition
        //     code is held in the exception's Microsoft.PointOfService.PosControlException.ErrorCodeExtended
        //     property.
        public static ErrorCode Extended
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Extended);
            }
        }

        //
        // Summary:
        //     The method has been deprecated and is no longer available.
        public static ErrorCode Deprecated
        {
            get
            {
                return new ErrorCode(Microsoft.PointOfService.ErrorCode.Deprecated);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ErrorCode other = (ErrorCode)obj;
            return this.InternalErrorCode.Equals(other.InternalErrorCode);
        }

        public override int GetHashCode()
        {
            return InternalErrorCode.GetHashCode();
        }

        public override string ToString()
        {
            return InternalErrorCode.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalErrorCode;
            }
        }

       
    }
}
