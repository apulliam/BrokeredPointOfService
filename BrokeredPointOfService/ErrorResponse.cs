using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the valid responses an application can make to an error event.
    public sealed class ErrorResponse : Enumeration
    {
        
        internal Microsoft.PointOfService.ErrorResponse InternalErrorResponse { get; set; }

        internal ErrorResponse(Microsoft.PointOfService.ErrorResponse errorResponse)
        {
            InternalErrorResponse = errorResponse;
        }
        

        // Summary:
        //     This response directs the device to retry the input. The error state is exited,
        //     and State is changed to Idle.
        public static ErrorResponse Retry
        {
            get
            {
                return new ErrorResponse(Microsoft.PointOfService.ErrorResponse.Retry);
            }
        }

        //
        // Summary:
        //     Clear the buffered DataEvent events and ErrorEvent events and exit the error
        //     state, changing State to Idle.
        public static ErrorResponse Clear
        {
            get
            {
                return new ErrorResponse(Microsoft.PointOfService.ErrorResponse.Clear);
            }
        }

        //
        // Summary:
        //     This response acknowledges the error and directs the device to continue processing.
        //     The device remains in the error state, and delivers additional data events
        //     as directed by the DataEventEnabled property. When all input has been delivered
        //     and the DataEventEnabled property is again set to TRUE, another ErrorEvent
        //     is delivered with locus Input.
        public static ErrorResponse ContinueInput
        {
            get
            {
                return new ErrorResponse(Microsoft.PointOfService.ErrorResponse.ContinueInput);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            ErrorResponse other = (ErrorResponse)obj;
            return this.InternalErrorResponse.Equals(other.InternalErrorResponse);
        }

        public override int GetHashCode()
        {
            return InternalErrorResponse.GetHashCode();
        }

        public override string ToString()
        {
            return InternalErrorResponse.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalErrorResponse;
            }
        }
    }
}
