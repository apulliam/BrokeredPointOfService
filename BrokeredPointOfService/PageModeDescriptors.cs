using System;

namespace BrokeredPointOfService
{
    // Summary:
    //     Lists the valid page mode functions of the printer for the selected PageModeStation.
    //  None                                        = 0  No function is supported.
    //  Bitmap                                      = 1  Printing of bitmaps on the PageModeStation is supported.
    //  Barcode                                     = 2  Printing of barcodes on the PageModeStation is supported
    //  BitmapBarcode                               = 3
    //  BitmapRotate                                = 4  Rotation of bitmaps on the PageModeStation is supported.
    //  BitmapBitmapRotate                          = 5
    //  BarcodeBitmapRotate                         = 6
    //  BitmapBarcodeBitmapRotate                   = 7
    //  BarcodeRotate                               = 8  Rotation of barcodes on the PageModeStation is supported.
    //  BitmapBarcodeRotate                         = 9
    //  BarcodeBarcodeRotate                        = 10
    //  BitmapBarcodeBarcodeRotate                  = 11
    //  BitmapRoteateBarcodeRotate                  = 12
    //  BitmapBitmapRotateBarcodeRotate             = 13
    //  BarcodeBitmpaRotateBarcodeRotate            = 14
    //  BitmapBarcodeBitmapRotateBarcodeRotate      = 15
    //  Opaque                                      = 16
    //  BitmapOpaque                                = 17
    //  BarcodeOpaque                               = 18
    //  BitmapBarcodeOpaque                         = 19
    //  BitmapRotateOpaque                          = 20
    //  BitmapBitmapRotateOpaque                    = 21
    //  BarcodeBitmapRotateOpaque                   = 22
    //  BitmapBarcodeBitmapRotateOpaque             = 23
    //  BarcodeRotateOpaque                         = 24
    //  BitmapBarcodeRotateOpaque                   = 25
    //  BarcodeBitmapBarcodeRotateOpaque            = 26
    //  BitmapBarcodeBarcodeRotateOpaque            = 27
    //  BitmapRotateBarcodeRotateOpaque             = 28
    //  BitmapBitmapRotateBarcodeRotateOpaque       = 29
    //  BarcodeBitmpaRotateBarcodeRotateOpaque      = 30
    //  BitmapBarcodeBitmapRotateBarcodeRotateOpaque = 31

    public sealed class PageModeDescriptors : Enumeration
    {
        internal Microsoft.PointOfService.PageModeDescriptors InternalPageModeDescriptors;

        internal PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors pageModeDescriptors)
        {
            InternalPageModeDescriptors = pageModeDescriptors;
        }

        // Summary:
        //     No function is supported.
        public static PageModeDescriptors None
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.None);
            }
        }

        //
        // Summary:
        //     Printing of bitmaps on the PageModeStation is supported.
        public static PageModeDescriptors Bitmap
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap);
            }
        }

        //
        // Summary:
        //     Printing of barcodes on the PageModeStation is supported.
        public static PageModeDescriptors Barcode
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode);
            }
        }

        public static PageModeDescriptors BitmapBarcode
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode);
            }
        }

        //
        // Summary:
        //     Rotation of bitmaps on the PageModeStation is supported.
        public static PageModeDescriptors BitmapRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.BitmapRotate);
            }
        }

        public static PageModeDescriptors BitmapBitmapRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate);
            }
        }

        public static PageModeDescriptors BarcodeBitmapRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate);
            }
        }

        public static PageModeDescriptors BitmapBarcodeBitmapRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate);
            }
        }

        //
        // Summary:
        //     Rotation of barcodes on the PageModeStation is supported.
        public static PageModeDescriptors BarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        public static PageModeDescriptors BitmapBarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        public static PageModeDescriptors BarcodeBarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        public static PageModeDescriptors BitmapBarcodeBarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        public static PageModeDescriptors BitmapRotateBarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        public static PageModeDescriptors BitmapBitmapRotateBarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        public static PageModeDescriptors BarcodeBitmapRotateBarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        public static PageModeDescriptors BitmapBarcodeBitmapRotateBarcodeRotate
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate);
            }
        }

        //
        // Summary:
        //     Text, graphics, and background are opaque, meaning items already placed on
        //     the page area in the specified print area will not be visible after being
        //     printed over.
        public static PageModeDescriptors Opaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.None);
            }
        }

        public static PageModeDescriptors BitmapOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BarcodeOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapBarcodeOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapBitmapRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BarcodeBitmapRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }


        public static PageModeDescriptors BitmapBarcodeBitmapRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate|
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapBarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BarcodeBitmapBarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapBarcodeBarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapRotateBarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapBitmapRotateBarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BarcodeBitmpaRotateBarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }

        public static PageModeDescriptors BitmapBarcodeBitmapRotateBarcodeRotateOpaque
        {
            get
            {
                return new PageModeDescriptors(Microsoft.PointOfService.PageModeDescriptors.Bitmap |
                                               Microsoft.PointOfService.PageModeDescriptors.Barcode |
                                               Microsoft.PointOfService.PageModeDescriptors.BitmapRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.BarcodeRotate |
                                               Microsoft.PointOfService.PageModeDescriptors.Opaque);
            }
        }



        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PageModeDescriptors other = (PageModeDescriptors)obj;
            return this.InternalPageModeDescriptors.Equals(other.InternalPageModeDescriptors);
        }

        public override int GetHashCode()
        {
            return InternalPageModeDescriptors.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPageModeDescriptors.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPageModeDescriptors;
            }
        }
    }
}