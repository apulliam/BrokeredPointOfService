// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible types of health checks to be performed on a device.
    public sealed class HealthCheckLevel : Enumeration
    {
        internal Microsoft.PointOfService.HealthCheckLevel InternalHealthCheckLevel { get; set; }

        internal HealthCheckLevel(Microsoft.PointOfService.HealthCheckLevel healthCheckLevel)
        {
            InternalHealthCheckLevel = healthCheckLevel;
        }

        // Summary:
        //     Performs a health check that does not physically change the device. The device
        //     is tested by internal tests to the extent possible.
        public static HealthCheckLevel Internal
        {
            get
            {
                return new HealthCheckLevel(Microsoft.PointOfService.HealthCheckLevel.Internal);
            }
        }

        //
        // Summary:
        //     Performs a more thorough test that may change the device. For example, a
        //     pattern may be printed on the printer.
        public static HealthCheckLevel External
        {
            get
            {
                return new HealthCheckLevel(Microsoft.PointOfService.HealthCheckLevel.External);
            }
        }

        //
        // Summary:
        //     Performs an interactive test of the device. The supporting service object
        //     typically displays a modal dialog box to present test options and results.
        public static HealthCheckLevel Interactive
        {
            get
            {
                return new HealthCheckLevel(Microsoft.PointOfService.HealthCheckLevel.Interactive);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            HealthCheckLevel other = (HealthCheckLevel)obj;
            return this.InternalHealthCheckLevel.Equals(other.InternalHealthCheckLevel);
        }

        public override int GetHashCode()
        {
            return InternalHealthCheckLevel.GetHashCode();
        }

        public override string ToString()
        {
            return InternalHealthCheckLevel.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalHealthCheckLevel;
            }
        }
    }
}

