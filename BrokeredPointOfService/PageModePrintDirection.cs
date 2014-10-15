using System;

namespace BrokeredPointOfService
{
    // Summary:
    //     Lists the possible print directions that can be set for a print station.
    public sealed class PageModePrintDirection : Enumeration
    {
        internal Microsoft.PointOfService.PageModePrintDirection InternalPageModePrintDirection { get; set; }

        internal PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection pageModePrintDirection)
        {
            InternalPageModePrintDirection = pageModePrintDirection;
        }

        // Summary:
        //     No valid station is selected.
        public static PageModePrintDirection None
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.None);
            }
        }

        //
        // Summary:
        //     Print left to right, starting at top left position of the print area (that
        //     is, normal printing).
        public static PageModePrintDirection LeftToRight
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.LeftToRight);
            }
        }

        //
        // Summary:
        //     Print bottom to top, starting at the bottom left position of the print area
        //     (that is, rotated left 90° printing).
        public static PageModePrintDirection BottomToTop
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.BottomToTop);
            }
        }

        //
        // Summary:
        //     Print right to left, starting at the bottom right position of the print area
        //     (that is, upside down printing).
        public static PageModePrintDirection RightToLeft
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.RightToLeft);
            }
        }

        //
        // Summary:
        //     Print top to bottom, starting at the top right position of the print area
        //     (that is, rotated right 90° printing.)
        public static PageModePrintDirection TopToBottom
        {
            get
            {
                return new PageModePrintDirection(Microsoft.PointOfService.PageModePrintDirection.TopToBottom);
            }
        }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PageModePrintDirection other = (PageModePrintDirection)obj;
            return this.InternalPageModePrintDirection.Equals(other.InternalPageModePrintDirection);
        }

        public override int GetHashCode()
        {
            return InternalPageModePrintDirection.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPageModePrintDirection.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPageModePrintDirection;
            }
        }
    }
}