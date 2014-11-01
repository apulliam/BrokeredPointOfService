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
    //     Enumerates the possible states of power notification for the current device.
    public sealed class PowerNotification : Enumeration
    {
        internal Microsoft.PointOfService.PowerNotification InternalPowerNotification { get; set; }

        internal PowerNotification(Microsoft.PointOfService.PowerNotification powerNotification)
        {
            this.InternalPowerNotification = powerNotification;
        }

        // Summary:
        //     The service object will not provide power notifications to the application.
        //     No power notification StatusUpdateEvent events will be raised, and the PowerState
        //     property may not be set.
        public static PowerNotification Disabled
        {
            get
            {
                return new PowerNotification(Microsoft.PointOfService.PowerNotification.Disabled);
            }
        }

        //
        // Summary:
        //     The service object will raise power notification StatusUpdateEvent events
        //     and update the PowerState property, beginning when the DeviceEnabled property
        //     is set to true. The level of functionality available depends on the value
        //     of the CapPowerReporting property.
        public static PowerNotification Enabled
        {
            get
            {
                return new PowerNotification(Microsoft.PointOfService.PowerNotification.Enabled);
            }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PowerNotification other = (PowerNotification)obj;
            return this.InternalPowerNotification.Equals(other.InternalPowerNotification);
        }

        public override int GetHashCode()
        {
            return InternalPowerNotification.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPowerNotification.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPowerNotification;
            }
        }
    }
}
