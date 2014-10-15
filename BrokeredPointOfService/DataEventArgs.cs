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
