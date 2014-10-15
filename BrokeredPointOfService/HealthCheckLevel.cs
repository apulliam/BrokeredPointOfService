
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

