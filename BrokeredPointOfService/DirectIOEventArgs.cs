using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{

    // Summary:
    //     Defines the programmatic interface for the transmission of Direct IO Events.
    public sealed class DirectIOEventArgs 
    {
        internal Microsoft.PointOfService.DirectIOEventArgs InternalDirectIOEventArgs { get; set; }

        internal DirectIOEventArgs(Microsoft.PointOfService.DirectIOEventArgs directIOEventArgs)
        {
            InternalDirectIOEventArgs = directIOEventArgs;
        }

        public int Data
        {
            get
            {
                return InternalDirectIOEventArgs.Data;
            }
            set
            {
                InternalDirectIOEventArgs.Data = value;
            }
        }
        
        public int EventNumber 
        {
            get
            {
                return InternalDirectIOEventArgs.EventNumber;
            }
        }
        
        public object Object 
        {
            get
            {
                return InternalDirectIOEventArgs.Object;
            }
            set
            {
                InternalDirectIOEventArgs.Object = value;
            }
        }

        public override string ToString()
        {
            return InternalDirectIOEventArgs.ToString();
        }
    }
}
