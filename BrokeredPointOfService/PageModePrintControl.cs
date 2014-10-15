using System;
using System.Diagnostics.CodeAnalysis;

namespace BrokeredPointOfService
{
    // Summary:
    //     Lists the valid Page Mode controls for a print station.
    public sealed class PageModePrintControl : Enumeration
    {
        internal Microsoft.PointOfService.PageModePrintControl InternalPageModePrintControl;

        internal PageModePrintControl(Microsoft.PointOfService.PageModePrintControl pageModePrintControl)
        {
            InternalPageModePrintControl = pageModePrintControl;
        }

        // Summary:
        //     Enter Page Mode.
        public static PageModePrintControl PageMode
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.PageMode);
            }
        }

        //
        // Summary:
        //     Print PageModePrintArea and save the canvas. Page Mode is not exited. Use
        //     for printing of repeated pages.
        public static PageModePrintControl PrintSave
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.PrintSave);
            }
        }

        //
        // Summary:
        //     Print the print area and destroy the canvas and exit Page Mode.
        public static PageModePrintControl Normal
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.Normal);
            }
        }

        //
        // Summary:
        //     Clear the page and exit the Page Mode without any printing of any print area.
        public static PageModePrintControl Cancel
        {
            get
            {
                return new PageModePrintControl(Microsoft.PointOfService.PageModePrintControl.Cancel);
            }
        }


         public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PageModePrintControl other = (PageModePrintControl)obj;
            return this.InternalPageModePrintControl.Equals(other.InternalPageModePrintControl);
        }

        public override int GetHashCode()
        {
            return InternalPageModePrintControl.GetHashCode();
        }
        public override string ToString()
        {
            return InternalPageModePrintControl.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPageModePrintControl;
            }
        }
    }
}