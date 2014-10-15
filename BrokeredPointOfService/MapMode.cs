using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Lists the valid units of measure for Printer, Check Scanner, and Point Card
    //     Reader Writer devices.
    public sealed class MapMode : Enumeration
    {
        internal Microsoft.PointOfService.MapMode InternalMapMode;

        internal MapMode(Microsoft.PointOfService.MapMode mapMode)
        {
            InternalMapMode = mapMode;
        }

        // Summary:
        //     The device's dot width.
        public static MapMode Dots 
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.Dots);
            }
        }

        //
        // Summary:
        //     1/1440 of an inch
        public static MapMode Twips 
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.Twips);
            }
        }

        //
        // Summary:
        //     0.001 inch
        public static MapMode English 
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.English);
            }
        }

        //
        // Summary:
        //     0.01 millimeter
        public static MapMode Metric
        {
            get
            {
                return new MapMode(Microsoft.PointOfService.MapMode.Metric);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            MapMode other = (MapMode)obj;
            return this.InternalMapMode.Equals(other.InternalMapMode);
        }

        public override int GetHashCode()
        {
            return InternalMapMode.GetHashCode();
        }

        public override string ToString()
        {
            return InternalMapMode.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalMapMode;
            }
        }
    }
}
