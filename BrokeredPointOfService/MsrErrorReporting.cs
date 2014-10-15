using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Lists the error reporting types for an MSR device.
    public sealed class MsrErrorReporting : Enumeration
    {
        internal Microsoft.PointOfService.MsrErrorReporting InternalMsrErrorReporting { get; set; }

        internal MsrErrorReporting(Microsoft.PointOfService.MsrErrorReporting msrErrorReporting)
        {
            this.InternalMsrErrorReporting = msrErrorReporting;
        }

        // Summary:
        //     Report errors at a card level.
        public static MsrErrorReporting Card
        {
            get
            {
                return new MsrErrorReporting(Microsoft.PointOfService.MsrErrorReporting.Card);
            }
        }

        //
        // Summary:
        //     Report errors at a track level.
        public static MsrErrorReporting Track
        {
            get
            {
                return new MsrErrorReporting(Microsoft.PointOfService.MsrErrorReporting.Track);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MsrErrorReporting other = (MsrErrorReporting)obj;
            return this.InternalMsrErrorReporting.Equals(other.InternalMsrErrorReporting);
        }

        public override int GetHashCode()
        {
            return InternalMsrErrorReporting.GetHashCode();
        }

        public override string ToString()
        {
            return InternalMsrErrorReporting.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalMsrErrorReporting;
            }
        }
    }
}
