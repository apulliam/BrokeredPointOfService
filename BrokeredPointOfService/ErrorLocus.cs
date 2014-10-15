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
