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
    //     Enumerates the possible power reporting capabilities of a device.
    public sealed class PowerReporting : Enumeration
    {
        internal Microsoft.PointOfService.PowerReporting InternalPowerReporting { get; set; }

        internal PowerReporting(Microsoft.PointOfService.PowerReporting powerReporting)
        {
        }

        // Summary:
        //     The service object cannot determine the state of the device. Therefore, no
        //     power reporting is possible.
        public static PowerReporting None
        {
            get
            {
                return new PowerReporting(Microsoft.PointOfService.PowerReporting.None);
            }
        }

        //
        // Summary:
        //     The service object can determine and report two of the power states, OffOffline
        //     (that is, Off or Offline) and Online.
        public static PowerReporting Standard
        {
            get
            {
                return new PowerReporting(Microsoft.PointOfService.PowerReporting.Standard);
            }
        }

        //
        // Summary:
        //     The service object can determine and report all three power states, Off,
        //     Offline, and Online.
        public static PowerReporting Advanced
        {
            get
            {
                return new PowerReporting(Microsoft.PointOfService.PowerReporting.Advanced);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PowerReporting other = (PowerReporting)obj;
            return this.InternalPowerReporting.Equals(other.InternalPowerReporting);
        }

        public override int GetHashCode()
        {
            return InternalPowerReporting.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPowerReporting.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPowerReporting;
            }
        }
    }
}
