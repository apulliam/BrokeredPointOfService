// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokeredPointOfService
{   // Summary:
    //     Enumerates the valid bar code symbol types.
    public sealed class BarCodeSymbology : Enumeration
    {
        internal Microsoft.PointOfService.BarCodeSymbology InternalBarCodeSymbology { get; set; }

        internal BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology barCodeSymbology)
        {
            this.InternalBarCodeSymbology = barCodeSymbology;
        }

        // Summary:
        //     The service object cannot determine the barcode symbology
        public static BarCodeSymbology Unknown
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Unknown);
            }
        }

        //
        // Summary:
        //     UPC-A
        public static BarCodeSymbology Upca
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upca);
            }
        }

        //
        // Summary:
        //     UPC-E
        public static BarCodeSymbology Upce
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upce);
            }
        }

        //
        // Summary:
        //     EAN/JAN-8
        public static BarCodeSymbology EanJan8
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.EanJan8);
            }
        }

        //
        // Summary:
        //     EAN/JAN-13
        public static BarCodeSymbology EanJan13
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.EanJan13);
            }
        }

        //
        // Summary:
        //     Standard (or discrete) 2 of 5
        public static BarCodeSymbology TF
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.TF);
            }
        }

        //
        // Summary:
        //     Interleaved 2 of 5
        public static BarCodeSymbology Itf
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Itf);
            }
        }

        //
        // Summary:
        //     CodaBar
        public static BarCodeSymbology Codabar
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Codabar);
            }
        }

        //
        // Summary:
        //     Code 39
        public static BarCodeSymbology Code39
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code39);
            }
        }

        //
        // Summary:
        //     Code 93
        public static BarCodeSymbology Code93
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code93);
            }

        }

        //
        // Summary:
        //     Code 128
        public static BarCodeSymbology Code128
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code128);
            }
        }

        //
        // Summary:
        //     UPC-A with supplemental barcode
        public static BarCodeSymbology Upcas
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upcas);
            }
        }

        //
        // Summary:
        //     UPC-E with supplemental barcode
        public static BarCodeSymbology Upces
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upces);
            }
        }

        //
        // Summary:
        //     UPC 1-digit supplement
        public static BarCodeSymbology Upcd1
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upcd1);
            }
        }

        //
        // Summary:
        //     UPC 2-digit supplement
        public static BarCodeSymbology Upcd2
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upcd2);
            }
        }

        //
        // Summary:
        //     UPC 3-digit supplement
        public static BarCodeSymbology Upcd3
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upcd3);
            }
        }

        //
        // Summary:
        //     UPC 4-digit supplement
        public static BarCodeSymbology Upcd4
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upcd4);
            }
        }

        //
        // Summary:
        //     UPC 5-digit supplement
        public static BarCodeSymbology Upcd5
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Upcd5);
            }
        }

        //
        // Summary:
        //     EAN-8
        public static BarCodeSymbology Ean8S
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ean8S);
            }
        }

        //
        // Summary:
        //     EAN-13
        public static BarCodeSymbology Ean13S
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ean13S);
            }
        }

        //
        // Summary:
        //     EAN-128
        public static BarCodeSymbology Ean128
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ean128);
            }
        }

        //
        // Summary:
        //     OCRa
        public static BarCodeSymbology Ocra
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ocra);
            }
        }

        //
        // Summary:
        //     OCRb
        public static BarCodeSymbology Ocrb
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ocrb);
            }
        }

        //
        // Summary:
        //     Code 128 with parsing
        public static BarCodeSymbology Code128Parsed
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code128Parsed);
            }
        }

        //
        // Summary:
        //     Reduced space symbology
        [Obsolete("Replaced by Gs1DataBar")]
        public static BarCodeSymbology Rss14
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Rss14);
            }
        }

        public static BarCodeSymbology Gs1DataBar
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Gs1DataBar);
            }
        }

        //
        // Summary:
        //     Reduced space symbology - expanded
        [Obsolete("Replaced by Gs1DataBarExpanded")]
        public static BarCodeSymbology RssExpanded
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.RssExpanded);
            }
        }

        public static BarCodeSymbology Gs1DataBarExpanded
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Gs1DataBarExpanded);
            }
        }

        //
        // Summary:
        //     ItfCK
        public static BarCodeSymbology ItfCK
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.ItfCK);
            }
        }

        public static BarCodeSymbology Gs1DataBarStackedOmnidirectional
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Gs1DataBarStackedOmnidirectional);
            }
        }

        public static BarCodeSymbology Gs1DataBarExpandedStacked
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Gs1DataBarExpandedStacked);
            }
        }

        //
        // Summary:
        //     Gs1DataBar_Type2
        public static BarCodeSymbology Gs1DataBar_Type2
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Gs1DataBar_Type2);
            }
        }

        //
        // Summary:
        //     Ames
        public static BarCodeSymbology Ames
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ames);
            }
        }

        //
        // Summary:
        //     TFMAT
        public static BarCodeSymbology TFMAT
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.TFMAT);
            }
        }

        //
        // Summary:
        //     Code39Ck
        public static BarCodeSymbology Code39Ck
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code39Ck);
            }
        }

        //
        // Summary:
        //     Code32
        public static BarCodeSymbology Code32
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code32);
            }
        }

        //
        // Summary:
        //     CodeCIP
        public static BarCodeSymbology CodeCIP
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.CodeCIP);
            }
        }

        //
        // Summary:
        //     TriOptic39
        public static BarCodeSymbology TriOptic39
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.TriOptic39);
            }
        }

        //
        // Summary:
        //     ISBT128
        public static BarCodeSymbology ISBT128
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.ISBT128);
            }
        }

        //
        // Summary:
        //     Code11
        public static BarCodeSymbology Code11
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code11);
            }
        }

        //
        // Summary:
        //     MSI
        public static BarCodeSymbology MSI
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.MSI);
            }
        }

        //
        // Summary:
        //     Plessey
        public static BarCodeSymbology Plessey
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Plessey);
            }
        }

        //
        // Summary:
        //     Telepen
        public static BarCodeSymbology Telepen
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Telepen);
            }
        }

        //
        // Summary:
        //     Composite Component A--up to 56 characters of data
        public static BarCodeSymbology Cca
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Cca);
            }
        }

        //
        // Summary:
        //     Composite Component B--up to 338 characters of data
        public static BarCodeSymbology Ccb
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ccb);
            }
        }

        //
        // Summary:
        //     Composite Conponent C--up to 2361 characters of data
        public static BarCodeSymbology Ccc
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Ccc);
            }
        }

        //
        // Summary:
        //     Tlc39
        public static BarCodeSymbology Tlc39
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Tlc39);
            }
        }

        //
        // Summary:
        //     PDF417
        public static BarCodeSymbology Pdf417
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Pdf417);
            }
        }

        //
        // Summary:
        //     Maxicode
        public static BarCodeSymbology Maxicode
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Maxicode);
            }
        }

        //
        // Summary:
        //     DataMatrix
        public static BarCodeSymbology DataMatrix
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.DataMatrix);
            }
        }

        //
        // Summary:
        //     QRCode
        public static BarCodeSymbology QRCode
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.QRCode);
            }
        }

        //
        // Summary:
        //     MicroQRCode
        public static BarCodeSymbology MicroQRCode
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.MicroQRCode);
            }
        }

        //
        // Summary:
        //     Aztec
        public static BarCodeSymbology Aztec
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Aztec);
            }
        }

        //
        // Summary:
        //     MicroPDF417
        public static BarCodeSymbology MicroPDF417
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.MicroPDF417);
            }
        }

        //
        // Summary:
        //     Gs1DataMatrix
        public static BarCodeSymbology Gs1DataMatrix
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Gs1DataMatrix);
            }
        }

        //
        // Summary:
        //     Gs1QRCode
        public static BarCodeSymbology Gs1QRCode
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Gs1QRCode);
            }
        }

        //
        // Summary:
        //     Code49
        public static BarCodeSymbology Code49
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code49);
            }
        }

        //
        // Summary:
        //     Code16k
        public static BarCodeSymbology Code16k
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Code16k);
            }
        }

        //
        // Summary:
        //     CodablockA
        public static BarCodeSymbology CodablockA
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.CodablockA);
            }
        }

        //
        // Summary:
        //     CodablockF
        public static BarCodeSymbology CodablockF
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.CodablockF);
            }
        }

        //
        // Summary:
        //     Codablock256
        public static BarCodeSymbology Codablock256
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Codablock256);
            }
        }

        //
        // Summary:
        //     HANXIN
        public static BarCodeSymbology HANXIN
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.HANXIN);
            }
        }

        //
        // Summary:
        //     AusPost
        public static BarCodeSymbology AusPost
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.AusPost);
            }
        }

        //
        // Summary:
        //     CanPost
        public static BarCodeSymbology CanPost
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.CanPost);
            }
        }

        //
        // Summary:
        //     ChinaPost
        public static BarCodeSymbology ChinaPost
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.ChinaPost);
            }
        }

        //
        // Summary:
        //     DutchKix
        public static BarCodeSymbology DutchKix
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.DutchKix);
            }
        }

        public static BarCodeSymbology InfoMail
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.InfoMail);
            }
        }

        //
        // Summary:
        //     JapanPost
        public static BarCodeSymbology JapanPost
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.JapanPost);
            }
        }

        //
        // Summary:
        //     KoreanPost
        public static BarCodeSymbology KoreanPost
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.KoreanPost);
            }
        }

        //
        // Summary:
        //     SwedenPost
        public static BarCodeSymbology SwedenPost
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.SwedenPost);
            }
        }

        //
        // Summary:
        //     UkPost
        public static BarCodeSymbology UkPost
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.UkPost);
            }
        }

        //
        // Summary:
        //     UsIntelligent
        public static BarCodeSymbology UsIntelligent
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.UsIntelligent);
            }
        }

        //
        // Summary:
        //     UsPlanet
        public static BarCodeSymbology UsPlanet
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.UsPlanet);
            }
        }

        //
        // Summary:
        //     PostNet
        public static BarCodeSymbology PostNet
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.PostNet);
            }
        }

        //
        // Summary:
        //     If greater than or equal to this type, the service object has returned an
        //     undefined symbology
        public static BarCodeSymbology Other
        {
            get
            {
                return new BarCodeSymbology(Microsoft.PointOfService.BarCodeSymbology.Other);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            BarCodeSymbology other = (BarCodeSymbology)obj;
            return this.InternalBarCodeSymbology.Equals(other.InternalBarCodeSymbology);
        }

        public override int GetHashCode()
        {
            return InternalBarCodeSymbology.GetHashCode();
        }

        public override string ToString()
        {
            return InternalBarCodeSymbology.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalBarCodeSymbology;
            }
        }
        
    }
}
