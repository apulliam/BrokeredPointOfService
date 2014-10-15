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
