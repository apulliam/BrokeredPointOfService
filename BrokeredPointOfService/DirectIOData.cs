using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{

    // Summary:
    //     Defines the programmatic structure the service object uses to return data
    //     to an application.
    public sealed class DirectIOData
    {
        internal Microsoft.PointOfService.DirectIOData InternalDirectIOData { get; set; }

        internal DirectIOData(Microsoft.PointOfService.DirectIOData directIOData)
        {
            InternalDirectIOData = directIOData;
        }

        //
        // Summary:
        //     Creates an instance of the DirectIOData structure with the specified data.
        //
        // Parameters:
        //   obj:
        //     An object.
        //
        //   data:
        //     Integer data.
        public DirectIOData(int data, object obj)
        {
            InternalDirectIOData = new Microsoft.PointOfService.DirectIOData(data, obj);
        }
  
        public int Data 
        {
            get
            {
                return InternalDirectIOData.Data;
            }
        }
        public object Object 
        {
            get
            {
                return InternalDirectIOData.Object;
            }
        }

        // Summary:
        //     Determines whether the specified Microsoft.PointOfService.DirectIOData is
        //     equal to the current Microsoft.PointOfService.DirectIOData.
        //
        // Parameters:
        //   d:
        //     The Microsoft.PointOfService.DirectIOData object to be compared to the current
        //     Microsoft.PointOfService.DirectIOData.
        //
        // Returns:
        //     A Boolean value that is true if the two instances are equal; otherwise, the
        //     value is false.
        public bool Equals(DirectIOData d)
        {
            return InternalDirectIOData.Equals(d);
        }
        //
        // Summary:
        //     Determines whether the specified Object is equal to the current Microsoft.PointOfService.DirectIOData.
        //
        // Parameters:
        //   obj:
        //     The object to be compared with the current Microsoft.PointOfService.DirectIOData.
        //
        // Returns:
        //     True if the specified object is equal to the current Microsoft.PointOfService.DirectIOData;
        //     otherwise, false.
        public bool EqualsObject(object obj)
        {
            return InternalDirectIOData.Equals(obj);
        }
      
        //
        // Summary:
        //     Returns the hash code of the current Microsoft.PointOfService.DirectIOData.
        //
        // Returns:
        //     An Int32 representation of the hash code for the current Microsoft.PointOfService.DirectIOData.
        public override int GetHashCode()
        {
            return InternalDirectIOData.GetHashCode();
        }
        //
        // Summary:
        //     Returns a string representation of the Microsoft.PointOfService.DirectIOData
        //     instance.
        //
        // Returns:
        //     A string representation of the Microsoft.PointOfService.DirectIOData.
        public override string ToString()
        {
            return InternalDirectIOData.ToString();
        }
    }
}
