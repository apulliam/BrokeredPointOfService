using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    public sealed class LineStyle : Enumeration
    {
        internal Microsoft.PointOfService.LineStyle InternalLineStyle;

        internal LineStyle(Microsoft.PointOfService.LineStyle lineStyle)
        {
            InternalLineStyle = lineStyle;
        }

        public static LineStyle SingleSolidLine
        {
            get
            {
                return new LineStyle(Microsoft.PointOfService.LineStyle.SingleSolidLine);
            }
        }

        public static LineStyle DoubleSolidLine
        {
            get
            {
                return new LineStyle(Microsoft.PointOfService.LineStyle.DoubleSolidLine);
            }
        }

        public static LineStyle BrokenLine
        {
            get
            {
                return new LineStyle(Microsoft.PointOfService.LineStyle.BrokenLine);
            }
        }

        public static LineStyle ChainLine
        {
            get
            {
                return new LineStyle(Microsoft.PointOfService.LineStyle.ChainLine);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            LineStyle other = (LineStyle)obj;
            return this.InternalLineStyle.Equals(other.InternalLineStyle);
        }

        public override int GetHashCode()
        {
            return InternalLineStyle.GetHashCode();
        }

        public override string ToString()
        {
            return InternalLineStyle.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalLineStyle;
            }
        }
    }
}