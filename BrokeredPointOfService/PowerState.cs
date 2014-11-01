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
    public sealed class PowerState : Enumeration
    {
        internal Microsoft.PointOfService.PowerState InternalPowerState { get; set; }

        internal PowerState(Microsoft.PointOfService.PowerState powerState)
        {
            this.InternalPowerState = powerState;
        }

        // Summary:
        //     Cannot determine the device's power state.
        public static PowerState Unknown
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Unknown);
            }
        }

        //
        // Summary:
        //     The device is turned on and ready for use.
        public static PowerState Online
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Online);
            }
        }

        //
        // Summary:
        //     The device is turned off or detached from the terminal.
        public static PowerState Off
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Off);
            }
        }

        //
        // Summary:
        //     The device is turned on but is either not ready or unable to respond to requests.
        public static PowerState Offline
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.Offline);
            }
        }

        //
        // Summary:
        //     The device is either turned off or offline.
        public static PowerState OffOffline
        {
            get
            {
                return new PowerState(Microsoft.PointOfService.PowerState.OffOffline);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null) 
                return false;

            PowerState other = (PowerState)obj;
            return this.InternalPowerState.Equals(other.InternalPowerState);
        }

        public override int GetHashCode()
        {
            return InternalPowerState.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPowerState.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPowerState;
            }
        }
    }

}
