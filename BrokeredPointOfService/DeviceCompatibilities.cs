using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the valid compatibility levels for a POS device.
    public sealed class DeviceCompatibilities : Enumeration
    {
         internal DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities value)
         {
              this.InternalDeviceCompatibilities = value;
         }

         internal Microsoft.PointOfService.DeviceCompatibilities InternalDeviceCompatibilities { get; set; }


         // Summary:
         //     Indicates compatibility with any COM service object.
         public static DeviceCompatibilities Opos 
         { 
             get 
             {
                 return new DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities.Opos); 
             } 
         }

         //
         // Summary:
         //     Indicates compatibility with any .NET service object.
         public static DeviceCompatibilities CompatibilityLevel1 
         { 
             get 
             {
                 return new DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities.CompatibilityLevel1); 
             } 
         }

        //
        // Summary:
        //     Indicates compatibility with any .NET or COM service object.
        public static DeviceCompatibilities OposAndCompatibilityLevel1
        {
            get
            {
                return new DeviceCompatibilities(Microsoft.PointOfService.DeviceCompatibilities.OposAndCompatibilityLevel1);
            }
        }
 
         public override bool Equals(object obj)
         {
             if (obj == null) 
                 return false;

             DeviceCompatibilities other = (DeviceCompatibilities)obj;
             return this.InternalDeviceCompatibilities.Equals(other.InternalDeviceCompatibilities);
         }

         public override int GetHashCode()
         {
             return InternalDeviceCompatibilities.GetHashCode();
         }

         public override string ToString()
         {
             return InternalDeviceCompatibilities.ToString();
         }

         public int Value
         {
             get
             {
                 return (int)InternalDeviceCompatibilities;
             }
         }
    }
}
