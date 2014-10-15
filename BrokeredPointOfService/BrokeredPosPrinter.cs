using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace BrokeredPointOfService
{
    internal class BrokeredPosPrinter : BrokeredPosCommon, PosPrinter, IDisposable
    {
        internal Microsoft.PointOfService.PosPrinter InternalPosPrinter
        {
            get
            {
                return (Microsoft.PointOfService.PosPrinter)InternalPosDevice;
            }
        }

        internal BrokeredPosPrinter(Microsoft.PointOfService.PosPrinter posPrinter) : base(posPrinter)
        {
            InternalPosPrinter.ErrorEvent += InternalPosPrinter_ErrorEvent;
        }

        void InternalPosPrinter_ErrorEvent(object sender, Microsoft.PointOfService.DeviceErrorEventArgs e)
        {
            if (ErrorEvent != null)
            {
                ErrorEvent(this, new DeviceErrorEventArgs(e));
            }
        }

        public bool AsyncMode
        {
            get
            {
                return InternalPosPrinter.AsyncMode;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.AsyncMode = value;
                    });
            }
        }

        public CharacterSetCapability CapCharacterSet
        {
            get 
            {
                return new CharacterSetCapability(InternalPosPrinter.CapCharacterSet); 
            }
        }

        public bool CapConcurrentJrnRec
        {
            get 
            {
                return InternalPosPrinter.CapConcurrentJrnRec; 
            }
        }

        public bool CapConcurrentJrnSlp
        {
            get 
            {
                return InternalPosPrinter.CapConcurrentJrnSlp;
            }
        }

        public bool CapConcurrentPageMode
        {
            get 
            {
                return InternalPosPrinter.CapConcurrentPageMode; 
            }
        }

        public bool CapConcurrentRecSlp
        {
            get 
            {
                return InternalPosPrinter.CapConcurrentRecSlp; 
            }
        }

        public bool CapCoverSensor
        {
            get 
            {
                return InternalPosPrinter.CapCoverSensor;
            }
        }

        public bool CapJrn2Color
        {
            get 
            {
                return InternalPosPrinter.CapJrn2Color; 
            }
        }

        public bool CapJrnBold
        {
            get 
            {
                return InternalPosPrinter.CapJrnBold; 
            }
        }

        public PrinterCartridgeSensors CapJrnCartridgeSensor
        {
            get 
            {
                return new PrinterCartridgeSensors(InternalPosPrinter.CapJrnCartridgeSensor);
            }
        }

        public PrinterColors CapJrnColor
        {
            get 
            {
                return new PrinterColors(InternalPosPrinter.CapJrnColor);
            }
        }

        public bool CapJrnDHigh
        {
            get 
            {
                return InternalPosPrinter.CapJrnDHigh;
            }
        }

        public bool CapJrnDWide
        {
            get 
            {
                return InternalPosPrinter.CapJrnDWide;
            }
        }

        public bool CapJrnDWideDHigh
        {
            get 
            {
                return InternalPosPrinter.CapJrnDWideDHigh;
            }
        }

        public bool CapJrnEmptySensor
        {
            get 
            {
                return InternalPosPrinter.CapJrnEmptySensor;
            }
        }

        public bool CapJrnItalic
        {
            get 
            {
                return InternalPosPrinter.CapJrnItalic;
            }
        }

        public bool CapJrnNearEndSensor
        {
            get 
            {
                return InternalPosPrinter.CapJrnNearEndSensor;
            }
        }

        public bool CapJrnPresent
        {
            get 
            {
                return InternalPosPrinter.CapJrnPresent;
            }
        }

        public bool CapJrnUnderline
        {
            get 
            {
                return InternalPosPrinter.CapJrnUnderline;
            }
        }

        public bool CapMapCharacterSet
        {
            get 
            {
                return InternalPosPrinter.CapMapCharacterSet;
            }
        }

        public bool CapRec2Color
        {
            get 
            {
                return InternalPosPrinter.CapRec2Color;
            }
        }

        public bool CapRecBarCode
        {
            get 
            {
                return InternalPosPrinter.CapRecBarCode;
            }
        }

        public bool CapRecBitmap
        {
            get 
            {
                return InternalPosPrinter.CapRecBitmap;
            }
        }

        public bool CapRecBold
        {
            get 
            {
                return InternalPosPrinter.CapRecBold;
            }
        }

        public PrinterCartridgeSensors CapRecCartridgeSensor
        {
            get 
            {
                return new PrinterCartridgeSensors(InternalPosPrinter.CapRecCartridgeSensor);
            }
        }

        public PrinterColors CapRecColor
        {
            get 
            {
                return new PrinterColors(InternalPosPrinter.CapRecColor);
            }
        }

        public bool CapRecDHigh
        {
            get 
            {
                return InternalPosPrinter.CapRecDHigh;
            }
        }

        public bool CapRecDWide
        {
            get 
            {
                return InternalPosPrinter.CapRecDWide;
            }
        }

        public bool CapRecDWideDHigh
        {
            get 
            {
                return InternalPosPrinter.CapRecDWideDHigh;
            }
        }

        public bool CapRecEmptySensor
        {
            get 
            {
                return InternalPosPrinter.CapRecEmptySensor;
            }
        }

        public bool CapRecItalic
        {
            get 
            {
                return InternalPosPrinter.CapRecItalic;
            }
        }

        public bool CapRecLeft90
        {
            get 
            {
                return InternalPosPrinter.CapRecLeft90;
            }
        }

        public PrinterMarkFeeds CapRecMarkFeed
        {
            get 
            {
                return new PrinterMarkFeeds(InternalPosPrinter.CapRecMarkFeed);
            }
        }

        public bool CapRecNearEndSensor
        {
            get 
            {
                return InternalPosPrinter.CapRecNearEndSensor;
            }
        }

        public bool CapRecPageMode
        {
            get 
            {
                return InternalPosPrinter.CapRecPageMode;
            }
        }

        public bool CapRecPaperCut
        {
            get 
            {
                return InternalPosPrinter.CapRecPaperCut;
            }
        }

        public bool CapRecPresent
        {
            get 
            {
                return InternalPosPrinter.CapRecPresent;
            }
        }

        public bool CapRecRight90
        {
            get 
            {
                return InternalPosPrinter.CapRecRight90;
            }
        }

        public bool CapRecRotate180
        {
            get 
            {
                return InternalPosPrinter.CapRecRotate180;
            }
        }

        public LineDirection CapRecRuledLine
        {
            get 
            {
                return new LineDirection(InternalPosPrinter.CapRecRuledLine);
            }
        }

        public bool CapRecStamp
        {
            get 
            {
                return InternalPosPrinter.CapRecStamp;
            }
        }

        public bool CapRecUnderline
        {
            get 
            {
                return InternalPosPrinter.CapRecUnderline;
            }
        }

        public bool CapSlp2Color
        {
            get 
            {
                return InternalPosPrinter.CapSlp2Color;
            }
        }

        public bool CapSlpBarCode
        {
            get 
            {
                return InternalPosPrinter.CapSlpBarCode;
            }
        }

        public bool CapSlpBitmap
        {
            get 
            {
                return InternalPosPrinter.CapSlpBitmap;
            }
        }

        public bool CapSlpBold
        {
            get 
            {
                return InternalPosPrinter.CapSlpBold;
            }
        }

        public bool CapSlpBothSidesPrint
        {
            get 
            {
                return InternalPosPrinter.CapSlpBothSidesPrint;
            }
        }

        public PrinterCartridgeSensors CapSlpCartridgeSensor
        {
            get 
            {
                return new PrinterCartridgeSensors(InternalPosPrinter.CapSlpCartridgeSensor);
            }
        }

        public PrinterColors CapSlpColor
        {
            get 
            {
                return new PrinterColors(InternalPosPrinter.CapSlpColor);
            }
        }

        public bool CapSlpDHigh
        {
            get 
            {
                return InternalPosPrinter.CapSlpDHigh;
            }
        }

        public bool CapSlpDWide
        {
            get 
            {
                return InternalPosPrinter.CapSlpDWide;
            }
        }

        public bool CapSlpDWideDHigh
        {
            get 
            {
                return InternalPosPrinter.CapSlpDWideDHigh;
            }
        }

        public bool CapSlpEmptySensor
        {
            get 
            {
                return InternalPosPrinter.CapSlpEmptySensor;
            }
        }

        public bool CapSlpFullSlip
        {
            get 
            {
                return InternalPosPrinter.CapSlpFullSlip;
            }
        }

        public bool CapSlpItalic
        {
            get 
            {
                return InternalPosPrinter.CapSlpItalic;
            }
        }

        public bool CapSlpLeft90
        {
            get 
            {
                return InternalPosPrinter.CapSlpLeft90;
            }
        }

        public bool CapSlpNearEndSensor
        {
            get 
            {
                return InternalPosPrinter.CapSlpNearEndSensor;
            }
        }

        public bool CapSlpPageMode
        {
            get 
            {
                return InternalPosPrinter.CapSlpPageMode;
            }
        }

        public bool CapSlpPresent
        {
            get 
            {
                return InternalPosPrinter.CapSlpPresent;
            }
        }

        public bool CapSlpRight90
        {
            get 
            {
                return InternalPosPrinter.CapSlpRight90;
            }
        }

        public bool CapSlpRotate180
        {
            get 
            {
                return InternalPosPrinter.CapSlpRotate180;
            }
        }

        public LineDirection CapSlpRuledLine
        {
            get 
            {
                return new LineDirection(InternalPosPrinter.CapSlpRuledLine);
            }
        }

        public bool CapSlpUnderline
        {
            get 
            {
                return InternalPosPrinter.CapSlpUnderline;
            }
        }

        public bool CapTransaction
        {
            get 
            {
                return InternalPosPrinter.CapTransaction;
            }
        }

        public PrinterCartridgeNotify CartridgeNotify
        {
            get
            {
                return new PrinterCartridgeNotify(InternalPosPrinter.CartridgeNotify);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.CartridgeNotify = value.InternalPrinterCartridgeNotify;
                    });
            }
        }

        public int CharacterSet
        {
            get
            {
                return InternalPosPrinter.CharacterSet;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.CharacterSet = value;
                    });
            }
        }

        public int[] CharacterSetList
        {
            get 
            {
                return InternalPosPrinter.CharacterSetList;
            }
        }

        public bool CoverOpen
        {
            get 
            {
                return InternalPosPrinter.CoverOpen;
            }
        }

        public PrinterErrorLevel ErrorLevel
        {
            get 
            {
                return new PrinterErrorLevel(InternalPosPrinter.ErrorLevel);
            }
        }

        public PrinterStation ErrorStation
        {
            get 
            {
                return new PrinterStation(InternalPosPrinter.ErrorStation);
            }
        }

        public string ErrorString
        {
            get 
            {
                return InternalPosPrinter.ErrorString;
            }
        }

        public bool FlagWhenIdle
        {
            get
            {
                return InternalPosPrinter.FlagWhenIdle;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.FlagWhenIdle = value;
                    });
            }
        }

        public string[] FontTypefaceList
        {
            get 
            {
                return InternalPosPrinter.FontTypefaceList;
            }
        }

        public PrinterCartridgeStates JrnCartridgeState
        {
            get 
            {
                return new PrinterCartridgeStates(InternalPosPrinter.JrnCartridgeState);
            }
        }

        public PrinterColors JrnCurrentCartridge
        {
            get
            {
                return new PrinterColors(InternalPosPrinter.JrnCurrentCartridge);
            }
            set
            {
                ExecuteAction(() =>
                {
                    InternalPosPrinter.JrnCurrentCartridge = value.InternalPrintColors;
                });
            }
        }

        public bool JrnEmpty
        {
            get 
            {
                return InternalPosPrinter.JrnEmpty;
            }
        }

        public bool JrnLetterQuality
        {
            get
            {
                return InternalPosPrinter.JrnLetterQuality;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.JrnLetterQuality = value;
                    });
            }
        }

        public int JrnLineChars
        {
            get
            {
                return InternalPosPrinter.JrnLineChars;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.JrnLineChars = value;
                    });
            }
        }

        public int[] JrnLineCharsList
        {
            get 
            {
                return InternalPosPrinter.JrnLineCharsList;
            }
        }

        public int JrnLineHeight
        {
            get
            {
                return InternalPosPrinter.JrnLineHeight;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.JrnLineHeight = value;
                    });
            }
        }

        public int JrnLineSpacing
        {
            get
            {
                return InternalPosPrinter.JrnLineSpacing;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.JrnLineSpacing = value;
                    });
            }
        }

        public int JrnLineWidth
        {
            get 
            {
                return InternalPosPrinter.JrnLineWidth;
            }
        }

        public bool JrnNearEnd
        {
            get 
            {
                return InternalPosPrinter.JrnNearEnd;
            }
        }

        public bool MapCharacterSet
        {
            get
            {
                return InternalPosPrinter.MapCharacterSet;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.MapCharacterSet = value;
                    });
            }
        }

        public MapMode MapMode
        {
            get
            {
                return new MapMode(InternalPosPrinter.MapMode);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.MapMode = value.InternalMapMode;
                    });
            }
        }

        public int OutputId
        {
            get 
            {
                return InternalPosPrinter.OutputId;
            }
        }

        public Windows.Foundation.Point PageModeArea
        {
            get
            {
                return new  Windows.Foundation.Point(InternalPosPrinter.PageModeArea.X, InternalPosPrinter.PageModePrintArea.Y);
            }
        }

        public PageModeDescriptors PageModeDescriptor
        {
            get 
            { 
                return new PageModeDescriptors(InternalPosPrinter.PageModeDescriptor);
            }
        }

        public int PageModeHorizontalPosition
        {
            get
            {
                return InternalPosPrinter.PageModeHorizontalPosition;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.PageModeHorizontalPosition = value;
                    });
            }
        }
        public Windows.Foundation.Rect PageModePrintArea
        {
            get
            {
                return new Windows.Foundation.Rect()
                {
                    X = InternalPosPrinter.PageModePrintArea.X,
                    Y = InternalPosPrinter.PageModePrintArea.Y,
                    Height = InternalPosPrinter.PageModePrintArea.Height,
                    Width = InternalPosPrinter.PageModePrintArea.Width
                };
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.PageModePrintArea = new System.Drawing.Rectangle((int)value.X, (int)value.Y, (int)value.Width, (int)value.Height);
                    });
            }
        }

        public PageModePrintDirection PageModePrintDirection
        {
            get
            {
                return new PageModePrintDirection(InternalPosPrinter.PageModePrintDirection);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.PageModePrintDirection = value.InternalPageModePrintDirection;
                    });
            }
        }

        public PrinterStation PageModeStation
        {
            get
            {
                return new PrinterStation(InternalPosPrinter.PageModeStation);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.PageModeStation = value.InternalPrinterStation;
                    });
            }
        }

        public int PageModeVerticalPosition
        {
            get
            {
                return InternalPosPrinter.PageModeVerticalPosition;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.PageModeVerticalPosition = value;
                    });
            }
        }

        public Rotation[] RecBarCodeRotationList
        {
            get 
            {
                var rotationList = new List<Rotation>();
                foreach (var internalRotation in InternalPosPrinter.RecBarCodeRotationList)
                    rotationList.Add(new Rotation(internalRotation));
                return rotationList.ToArray();
            }
        }

        public Rotation[] RecBitmapRotationList
        {
            get 
            {
                var rotationList = new List<Rotation>();
                foreach (var internalRotation in InternalPosPrinter.RecBitmapRotationList)
                    rotationList.Add(new Rotation(internalRotation));
                return rotationList.ToArray();
            }
        }

        public PrinterCartridgeStates RecCartridgeState
        {
            get 
            {
                return new PrinterCartridgeStates(InternalPosPrinter.RecCartridgeState);
            }
        }

        public PrinterColors RecCurrentCartridge
        {
            get
            {
                return new PrinterColors(InternalPosPrinter.RecCurrentCartridge);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.RecCurrentCartridge = value.InternalPrintColors;
                    });
            }
        }

        public bool RecEmpty
        {
            get 
            {
                return InternalPosPrinter.RecEmpty;
            }
        }

        public bool RecLetterQuality
        {
            get
            {
                return InternalPosPrinter.RecLetterQuality;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.RecLetterQuality = value;
                    });
            }
        }

        public int RecLineChars
        {
            get
            {
                return InternalPosPrinter.RecLineChars;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.RecLineChars = value;
                    });
            }
        }

        public int[] RecLineCharsList
        {
            get 
            {
                return InternalPosPrinter.RecLineCharsList;
            }
        }

        public int RecLineHeight
        {
            get
            {
                return InternalPosPrinter.RecLineHeight;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.RecLineHeight = value;
                    });
            }
        }

        public int RecLineSpacing
        {
            get
            {
                return InternalPosPrinter.RecLineSpacing;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.RecLineSpacing = value;
                    });
            }
        }

        public int RecLinesToPaperCut
        {
            get 
            {
                return InternalPosPrinter.RecLinesToPaperCut;
            }
        }

        public int RecLineWidth
        {
            get 
            {
                return InternalPosPrinter.RecLineWidth;
            }
        }

        public bool RecNearEnd
        {
            get 
            {
                return InternalPosPrinter.RecNearEnd;
            }
        }

        public int RecSidewaysMaxChars
        {
            get 
            {
                return InternalPosPrinter.RecSidewaysMaxChars;
            }
        }

        public int RecSidewaysMaxLines
        {
            get 
            {
                return InternalPosPrinter.RecSidewaysMaxLines;
            }
        }

        public Rotation RotateSpecial
        {
            get
            {
                return new Rotation(InternalPosPrinter.RotateSpecial);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.RotateSpecial = value.InternalRotation;
                    });
            }
        }

        public Rotation[] SlpBarCodeRotationList
        {
            get 
            {
                var rotationList = new List<Rotation>();
                foreach (var internalRotation in InternalPosPrinter.SlpBarCodeRotationList)
                    rotationList.Add(new Rotation(internalRotation));
                return rotationList.ToArray(); 
            }
        }

        public Rotation[] SlpBitmapRotationList
        {
            get 
            {
                var rotationList = new List<Rotation>();
                foreach (var internalRotation in InternalPosPrinter.SlpBitmapRotationList)
                    rotationList.Add(new Rotation(internalRotation));
                return rotationList.ToArray(); 
            }
        }

        public PrinterCartridgeStates SlpCartridgeState
        {
            get 
            { 
                return new  PrinterCartridgeStates(InternalPosPrinter.SlpCartridgeState);
            }
        }

        public PrinterColors SlpCurrentCartridge
        {
            get
            {
                return new PrinterColors(InternalPosPrinter.SlpCurrentCartridge);
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.SlpCurrentCartridge = value.InternalPrintColors;
                    });
            }
        }

        public bool SlpEmpty
        {
            get 
            {
                return InternalPosPrinter.SlpEmpty;
            }
        }

        public bool SlpLetterQuality
        {
            get
            {
                return InternalPosPrinter.SlpLetterQuality;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.SlpLetterQuality = value;
                    });
            }
        }

        public int SlpLineChars
        {
            get
            {
                return InternalPosPrinter.SlpLineChars;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.SlpLineChars = value;
                    });
            }
        }

        public int[] SlpLineCharsList
        {
            get 
            {
                return InternalPosPrinter.SlpLineCharsList;
            }
        }

        public int SlpLineHeight
        {
            get
            {
                return InternalPosPrinter.SlpLineHeight;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.SlpLineHeight = value;
                    });
            }
        }

        public int SlpLinesNearEndToEnd
        {
            get 
            {
                return InternalPosPrinter.SlpLinesNearEndToEnd;
            }
        }

        public int SlpLineSpacing
        {
            get
            {
                return InternalPosPrinter.SlpLineSpacing;
            }
            set
            {
                ExecuteAction(() =>
                    {
                        InternalPosPrinter.SlpLineSpacing = value;
                    });
            }
        }

        public int SlpLineWidth
        {
            get 
            {
                return InternalPosPrinter.SlpLineWidth;
            }
        }

        public int SlpMaxLines
        {
            get 
            {
                return InternalPosPrinter.SlpMaxLines;
            }
        }

        public bool SlpNearEnd
        {
            get 
            {
                return InternalPosPrinter.SlpNearEnd;
            }
        }

        public PrinterSide SlpPrintSide
        {
            get 
            { 
                return new PrinterSide(InternalPosPrinter.SlpPrintSide); 
            }
        }

        public int SlpSidewaysMaxChars
        {
            get 
            { 
                return InternalPosPrinter.SlpSidewaysMaxChars; 
            }
        }

        public int SlpSidewaysMaxLines
        {
            get 
            { 
                return InternalPosPrinter.SlpSidewaysMaxLines; 
            }
        }

        public event Windows.Foundation.TypedEventHandler<PosPrinter, DeviceErrorEventArgs> ErrorEvent;

        public IAsyncOperation<int> BeginInsertion(int timeout)
        {
            return Task.Run(() =>
                {
                    return ExecuteFunction(() =>
                        {
                            InternalPosPrinter.BeginInsertion(timeout);
                            return 0;
                        });
                }).AsAsyncOperation();
        }

        public IAsyncOperation<int> BeginRemoval(int timeout)
        {
            return Task.Run(() =>
                {
                    return ExecuteFunction(() =>
                        {
                            InternalPosPrinter.BeginRemoval(timeout);
                            return 0;
                        });
                }).AsAsyncOperation<int>();
        }

        public void ChangePrintSide(PrinterSide side)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.ChangePrintSide(side.InternalPrinterSide);
                });
        }

        public void ClearOutput()
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.ClearOutput();
                });
        }

        public void ClearPrintArea()
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.ClearPrintArea();
                });
        }

        public void CutPaper(int percentage)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.CutPaper(percentage);
                });
        }

        public void DrawRuledLine(PrinterStation station, string positionList, LineDirection direction, int lineWidth, LineStyle style, int lineColor)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.DrawRuledLine(station.InternalPrinterStation, positionList, direction.InternalLineDirection, lineWidth, style.InternalLineStyle, lineColor);
                });
        }

        public void EndInsertion()
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.EndInsertion();
                });
        }

        public void EndRemoval()
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.EndRemoval();
                });
        }

        public void MarkFeed(PrinterMarkFeeds type)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.MarkFeed(type.InternalPrinterMarkFeeds);
                });
        }

        public void PageModePrint(PageModePrintControl control)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.PageModePrint(control.InternalPageModePrintControl);
                });
        }

        public void PrintBarCode(PrinterStation station, string data, BarCodeSymbology symbology, int height, int width, int alignment, BarCodeTextPosition textPosition)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.PrintBarCode(station.InternalPrinterStation, data, symbology.InternalBarCodeSymbology, height, width, alignment, textPosition.InternalBarCodeTextPosition);
                });
        }

        public void PrintBitmap(PrinterStation station, string fileName, int width, int alignment)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.PrintBitmap(station.InternalPrinterStation, fileName, width, alignment);
                });
        }

        public void PrintImmediate(PrinterStation station, string data)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.PrintImmediate(station.InternalPrinterStation, data);
                });
        }

        public void PrintNormal(PrinterStation station, string data)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.PrintNormal(station.InternalPrinterStation, data);
                });
        }

        public void PrintTwoNormal(PrinterStation station, string data1, string data2)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.PrintTwoNormal(station.InternalPrinterStation, data1, data2);
                });
        }

        public void RotatePrint(PrinterStation station, PrintRotation rotation)
        {
            InternalPosPrinter.RotatePrint(station.InternalPrinterStation, rotation.InternalPrintRotation);
        }

        public void SetBitmap(int bitmapNumber, PrinterStation station, string fileName, int width, int alignment)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.SetBitmap(bitmapNumber, station.InternalPrinterStation, fileName, width, alignment);
                });
        }

        public void SetLogo(PrinterLogoLocation location, string data)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.SetLogo(location.InternalPrinterLogoLocation, data);
                });
        }

        public void TransactionPrint(PrinterStation station, PrinterTransactionControl control)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.TransactionPrint(station.InternalPrinterStation, control.InternalPrinterTransactionControl);
                });
        }

        public void ValidateData(PrinterStation station, string data)
        {
            ExecuteAction(() =>
                {
                    InternalPosPrinter.ValidateData(station.InternalPrinterStation, data);
                });
        }

        public new void Dispose()
        {
            InternalPosPrinter.ErrorEvent -= InternalPosPrinter_ErrorEvent;
            base.Dispose();
        }
    }
}
