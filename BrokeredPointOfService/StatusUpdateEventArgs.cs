using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Defines the programmatic interface for the transmission of Status Update
    //     Events.
    public sealed class StatusUpdateEventArgs : PosEventArgs
    {
        internal Microsoft.PointOfService.StatusUpdateEventArgs InternalStatusUpdateEventArgs { get; set; }

        // Summary:
        //     Creates an instance of the StatusUpdateEventArgs class with the specified
        //     data.
        //
        // Parameters:
        //   status:
        //     Device-specific status, describing the type of status change.
        internal StatusUpdateEventArgs(Microsoft.PointOfService.StatusUpdateEventArgs statusUpdateEventArgs)
        {
            InternalStatusUpdateEventArgs = statusUpdateEventArgs;
        }


        // Summary:
        //     Gets the event identifier.
        public int EventId
        {
            get
            {
                return InternalStatusUpdateEventArgs.EventId;
            }
        }

        //
        // Summary:
        //     Gets the DateTime of the event.
        public DateTimeOffset TimeStamp
        {
            get
            {
                return new DateTimeOffset(InternalStatusUpdateEventArgs.TimeStamp);
            }
        }

        // Summary:
        //     Holds the device-specific status, describing the type of status change.
        public int Status 
        {
            get
            {
                return InternalStatusUpdateEventArgs.Status;
            }
        }

        public override string ToString()
        {
            return InternalStatusUpdateEventArgs.ToString();
        }
    }
}
