using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{
    public sealed class LineDirection : Enumeration
    {
        internal Microsoft.PointOfService.LineDirection InternalLineDirection;

        internal LineDirection(Microsoft.PointOfService.LineDirection lineDirection)
        {
            InternalLineDirection = lineDirection;
        }

        public static LineDirection None
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.None);
            }
        }

        public static LineDirection Horizontal
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.Horizontal);
            }
        }

        public static LineDirection Vertical
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.Vertical);
            }
        }

        public static LineDirection HorizonatlVertical
        {
            get
            {
                return new LineDirection(Microsoft.PointOfService.LineDirection.Horizontal | Microsoft.PointOfService.LineDirection.Vertical);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            LineDirection other = (LineDirection)obj;
            return this.InternalLineDirection.Equals(other.InternalLineDirection);
        }

        public override int GetHashCode()
        {
            return InternalLineDirection.GetHashCode();
        }

        public override string ToString()
        {
            return InternalLineDirection.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalLineDirection;
            }
        }
    }
}
