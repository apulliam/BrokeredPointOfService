using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the valid states of a device.
    public sealed class ControlState : Enumeration
    {
        internal Microsoft.PointOfService.ControlState InternalControlState { get; set; }

        internal ControlState(Microsoft.PointOfService.ControlState controlState)
        {
            this.InternalControlState = controlState;
        }

        // Summary:
        //     The device is closed. The service object is not initialized.
        public static ControlState Closed
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Closed);
            }
        }

        //
        // Summary:
        //     The device is in a good state and is not busy.
        public static ControlState Idle
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Idle);
            }
        }

        //
        // Summary:
        //     The device is in a good state and is busy performing output.
        public static ControlState Busy
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Busy);
            }
        }
        //
        // Summary:
        //     An error has been reported, and the application must recover the Control
        //     to a good state before normal I/O can resume.
        public static ControlState Error
        {
            get
            {
                return new ControlState(Microsoft.PointOfService.ControlState.Error);
            }
        }

         public override bool Equals(object obj)
         {
             if (obj == null) 
                 return false;

             ControlState other = (ControlState)obj;
             return this.InternalControlState.Equals(other.InternalControlState);
         }

         public override int GetHashCode()
         {
             return InternalControlState.GetHashCode();
         }

         public override string ToString()
         {
             return InternalControlState.ToString();
         }

         public int Value
         {
             get
             {
                 return (int)InternalControlState;
             }
         }
       
    }
}
