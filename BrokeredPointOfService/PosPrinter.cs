using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace BrokeredPointOfService
{
    // Summary:
    //     Defines the programmatic interface for a UPOS Printer device.
    public interface PosPrinter : PosCommon
    {
        // Summary:
        //     Gets or sets a Boolean value that indicates whether certain print methods
        //     will be performed asynchronously.
        bool AsyncMode { get; set; }
        //
        // Summary:
        //     Gets the default character set capability.
        CharacterSetCapability CapCharacterSet { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal and receipt stations
        //     can print at the same time.
        bool CapConcurrentJrnRec { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal and slip stations
        //     can print at the same time.
        bool CapConcurrentJrnSlp { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the printer can support Page
        //     Mode at the same time for both the receipt and slip stations.
        bool CapConcurrentPageMode { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt and slip stations
        //     can print at the same time.
        bool CapConcurrentRecSlp { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the printer has a "cover open"
        //     sensor.
        bool CapCoverSensor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal can print dark plus
        //     an alternate color.
        bool CapJrn2Color { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal can print bold characters.
        bool CapJrnBold { get; }
        //
        // Summary:
        //     Gets the presence of journal cartridge monitoring sensors.
        PrinterCartridgeSensors CapJrnCartridgeSensor { get; }
        //
        // Summary:
        //     Gets available journal color cartridges.
        PrinterColors CapJrnColor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal can print double-high
        //     characters.
        bool CapJrnDHigh { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal can print double-wide
        //     characters.
        bool CapJrnDWide { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal can print characters
        //     that are both double-high and double-wide.
        bool CapJrnDWideDHigh { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal has an out-of-paper
        //     sensor.
        bool CapJrnEmptySensor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal can print italic
        //     characters.
        bool CapJrnItalic { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal has a low-paper sensor.
        bool CapJrnNearEndSensor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal print station is
        //     present.
        bool CapJrnPresent { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal can underline characters.
        bool CapJrnUnderline { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether when printing data, the service
        //     object can map the characters sent by the application (in the character set
        //     that is defined by the CharacterSet property) to the character sets that
        //     are defined by the CharacterSetList property.
        bool CapMapCharacterSet { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print dark plus
        //     an alternate color.
        bool CapRec2Color { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt has bar code printing
        //     capability.
        bool CapRecBarCode { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print bitmaps.
        bool CapRecBitmap { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print bold characters.
        bool CapRecBold { get; }
        //
        // Summary:
        //     Gets the presence of receipt cartridge monitoring sensors.
        PrinterCartridgeSensors CapRecCartridgeSensor { get; }
        //
        // Summary:
        //     Gets the receipt color cartridges.
        PrinterColors CapRecColor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print double-high
        //     characters.
        bool CapRecDHigh { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print double-wide
        //     characters.
        bool CapRecDWide { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print double-high,
        //     double-wide characters.
        bool CapRecDWideDHigh { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt has an out-of-paper
        //     sensor.
        bool CapRecEmptySensor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print italic
        //     characters.
        bool CapRecItalic { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print in rotated-90-degree-left
        //     mode.
        bool CapRecLeft90 { get; }
        //
        // Summary:
        //     Gets the type of mark-sensed paper handling available.
        PrinterMarkFeeds CapRecMarkFeed { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt has a low-paper sensor.
        bool CapRecNearEndSensor { get; }
        bool CapRecPageMode { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can perform paper
        //     cuts.
        bool CapRecPaperCut { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt print station is
        //     present.
        bool CapRecPresent { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print in a rotated-90-degree-right
        //     mode.
        bool CapRecRight90 { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can print in a rotated
        //     upside-down mode.
        bool CapRecRotate180 { get; }
        LineDirection CapRecRuledLine { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt has a stamp capability.
        bool CapRecStamp { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt can underline characters.
        bool CapRecUnderline { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print dark plus
        //     an alternate color.
        bool CapSlp2Color { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip has bar code printing
        //     capability.
        bool CapSlpBarCode { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print bitmaps.
        bool CapSlpBitmap { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print bold characters.
        bool CapSlpBold { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip print station supports
        //     printing on both sides of the document.
        bool CapSlpBothSidesPrint { get; }
        //
        // Summary:
        //     Gets the presence of slip-cartridge monitoring sensors.
        PrinterCartridgeSensors CapSlpCartridgeSensor { get; }
        //
        // Summary:
        //     Gets the type of color cartridges supported for slip printing.
        PrinterColors CapSlpColor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print double-high
        //     characters.
        bool CapSlpDHigh { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print double-wide
        //     characters.
        bool CapSlpDWide { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print characters
        //     that are both double-wide and double-high.
        bool CapSlpDWideDHigh { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip has a "slip in" sensor.
        bool CapSlpEmptySensor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip is a full slip station;
        //     it can print full-length forms.
        bool CapSlpFullSlip { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print italic characters.
        bool CapSlpItalic { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print in a rotated
        //     90 degree left mode.
        bool CapSlpLeft90 { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip has a "slip near end"
        //     sensor.
        bool CapSlpNearEndSensor { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the printer can support Page
        //     Mode for the slip station.
        bool CapSlpPageMode { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip print station is present.
        bool CapSlpPresent { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print in a rotated-90-degree-right
        //     mode.
        bool CapSlpRight90 { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can print in an upside-down
        //     mode.
        bool CapSlpRotate180 { get; }
        LineDirection CapSlpRuledLine { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip can underline characters.
        bool CapSlpUnderline { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether each station supports printer
        //     transactions.
        bool CapTransaction { get; }
        //
        // Summary:
        //     Gets or sets the type of cartridge state notification the application wants
        //     to receive.
        PrinterCartridgeNotify CartridgeNotify { get; set; }
        //
        // Summary:
        //     Gets or sets the numeric value that indicates the character set that the
        //     application wants to use for printing characters.
        int CharacterSet { get; set; }
        //
        // Summary:
        //     Gets the list of character set numbers supported for printing.
        int[] CharacterSetList { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the printer’s cover is open.
        bool CoverOpen { get; }
        //
        // Summary:
        //     Gets the severity of the most recent error condition.
        PrinterErrorLevel ErrorLevel { get; }
        //
        // Summary:
        //     Gets the station or stations that were printing when an error was detected.
        PrinterStation ErrorStation { get; }
        //
        // Summary:
        //     Gets a vendor-supplied description of the current error.
        string ErrorString { get; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether the service object queues
        //     a StatusUpdateEvent event by using the StatusIdle constant when the device
        //     is in an idle state, and reset FlagWhenIdle to false.
        bool FlagWhenIdle { get; set; }
        //
        // Summary:
        //     Gets a string array that specifies the fonts and typefaces supported by the
        //     printer.
        string[] FontTypefaceList { get; }
        //
        // Summary:
        //     Gets the status of the selected journal cartridge (ink, ribbon, or toner).
        PrinterCartridgeStates JrnCartridgeState { get; }
        //
        // Summary:
        //     Gets or sets the currently selected journal cartridge.
        PrinterColors JrnCurrentCartridge { get; set; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether the journal is out of
        //     paper.
        bool JrnEmpty { get; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether the printer can print
        //     in high-quality mode.
        bool JrnLetterQuality { get; set; }
        //
        // Summary:
        //     Gets or sets the number of characters that the application wants to print
        //     on a journal line.
        int JrnLineChars { get; set; }
        //
        // Summary:
        //     Gets a collection of the line widths (characters per line) supported by the
        //     journal station.
        int[] JrnLineCharsList { get; }
        //
        // Summary:
        //     Gets or sets the journal print line height that the application wants to
        //     use, expressed in the unit of measure indicated by the MapMode property setting.
        int JrnLineHeight { get; set; }
        //
        // Summary:
        //     Gets or sets the spacing of each single-high print line, including both the
        //     printed line height and the white space between each pair of lines that the
        //     application wants to use.
        int JrnLineSpacing { get; set; }
        //
        // Summary:
        //     Gets the width of a line for the number of characters indicated by the JrnLineChars
        //     property, expressed in the unit of measure indicated by the MapMode property.
        int JrnLineWidth { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the journal paper is low.
        bool JrnNearEnd { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the service object maps the characters
        //     transferred by the application to the character set selected in the CharacterSet
        //     property.
        bool MapCharacterSet { get; set; }
        //
        // Summary:
        //     Gets or sets the mapping mode of the printer the application wants to use.
        MapMode MapMode { get; set; }
        //
        // Summary:
        //     Gets the identifier associated with the current output request.
        int OutputId { get; }
        //
        // Summary:
        //     Gets the page area for the selected PageModeStation expressed in the unit
        //     of measure given by MapMode.
        Windows.Foundation.Point PageModeArea { get; }
        //
        // Summary:
        //     Gets the basic Page mode functionality of the printer for the selected PageModeStation
        //     property.
        PageModeDescriptors PageModeDescriptor { get; }
        //
        // Summary:
        //     Gets or sets the horizontal start position offset within the print area for
        //     the print station specified by the PageModeStation property, expressed in
        //     the unit of measure specified by the MapMode property.
        int PageModeHorizontalPosition { get; set; }
        Windows.Foundation.Rect PageModePrintArea { get; set; }
        PageModePrintDirection PageModePrintDirection { get; set; }
        PrinterStation PageModeStation { get; set; }
        //
        // Summary:
        //     Gets or sets the vertical start position offset within the print area for
        //     the print station specified by the PageModeStation property, expressed in
        //     the unit of measure specified by the MapMode property.
        int PageModeVerticalPosition { get; set; }
        //
        // Summary:
        //     Gets a list of the directions in which a receipt bar code can be rotated.
        Rotation[] RecBarCodeRotationList { get; }
        //
        // Summary:
        //     Gets a list of the directions in which a receipt bitmap can be rotated.
        Rotation[] RecBitmapRotationList { get; }
        //
        // Summary:
        //     Gets the status of the selected receipt cartridge (ink, ribbon or toner).
        PrinterCartridgeStates RecCartridgeState { get; }
        //
        // Summary:
        //     Gets or sets the receipt cartridge selected by the application.
        PrinterColors RecCurrentCartridge { get; set; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt is out of paper.
        bool RecEmpty { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the printer prints in high-quality
        //     mode.
        bool RecLetterQuality { get; set; }
        //
        // Summary:
        //     Gets or sets the number of characters that the application wants to print
        //     on a receipt line.
        int RecLineChars { get; set; }
        //
        // Summary:
        //     Gets a collection of the line widths (characters per line) supported by the
        //     receipt station.
        int[] RecLineCharsList { get; }
        //
        // Summary:
        //     Gets or sets the receipt print line height, expressed in the unit of measure
        //     indicated by the MapMode property setting, that the application wants to
        //     use.
        int RecLineHeight { get; set; }
        //
        // Summary:
        //     Gets or sets the spacing of each single-high print line. This includes both
        //     the printed line height and the white space between each pair of lines, that
        //     the application wants to use.
        int RecLineSpacing { get; set; }
        //
        // Summary:
        //     Gets the number of lines that must be advanced before cutting the receipt
        //     paper.
        int RecLinesToPaperCut { get; }
        //
        // Summary:
        //     Gets the width of a line, based on the number of characters specified in
        //     the RecLineChars property, expressed in the unit of measure indicated by
        //     the MapMode property.
        int RecLineWidth { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the receipt paper is low.
        bool RecNearEnd { get; }
        //
        // Summary:
        //     Gets the maximum number of characters that can be printed on each line in
        //     sideways mode.
        int RecSidewaysMaxChars { get; }
        //
        // Summary:
        //     Gets the maximum number of lines that can be printed in sideways mode.
        int RecSidewaysMaxLines { get; }
        //
        // Summary:
        //     Gets or sets the rotation orientation for bar codes that the application
        //     wants to use.
        Rotation RotateSpecial { get; set; }
        //
        // Summary:
        //     Gets a collection of the directions in which a slip bar code may be rotated.
        Rotation[] SlpBarCodeRotationList { get; }
        //
        // Summary:
        //     Gets a collection of the directions in which a slip bitmap can be rotated.
        Rotation[] SlpBitmapRotationList { get; }
        //
        // Summary:
        //     Gets the status of the selected slip cartridge (ink, ribbon, or toner).
        PrinterCartridgeStates SlpCartridgeState { get; }
        //
        // Summary:
        //     Gets or sets the slip cartridge the application wants to use.
        PrinterColors SlpCurrentCartridge { get; set; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether a slip form is not present.
        bool SlpEmpty { get; }
        //
        // Summary:
        //     Gets or sets a Boolean value that indicates whether the printer prints in
        //     high-quality mode.
        bool SlpLetterQuality { get; set; }
        //
        // Summary:
        //     Gets or sets the number of characters that the application wants to print
        //     on a slip line.
        int SlpLineChars { get; set; }
        //
        // Summary:
        //     Gets a collection of the line widths (characters per line) supported by the
        //     slip station.
        int[] SlpLineCharsList { get; }
        //
        // Summary:
        //     Gets or sets the slip print-line height, expressed in the unit of measure
        //     indicated by the MapMode property setting, that the application wants to
        //     use.
        int SlpLineHeight { get; set; }
        //
        // Summary:
        //     Gets the number of lines that can be printed after the SlpNearEnd property
        //     has been set to true but before the printer reaches the end of the slip.
        int SlpLinesNearEndToEnd { get; }
        //
        // Summary:
        //     Gets or sets the spacing of each single-high print line. This includes both
        //     the printed line height and the white space between each pair of lines that
        //     the application wants to use.
        int SlpLineSpacing { get; set; }
        //
        // Summary:
        //     Gets the line width, based on the number of characters specified for the
        //     SlpLineChars property, expressed in the unit of measure indicated by the
        //     MapMode property.
        int SlpLineWidth { get; }
        //
        // Summary:
        //     Gets the maximum number of lines that can be printed on a form.
        int SlpMaxLines { get; }
        //
        // Summary:
        //     Gets a Boolean value that indicates whether the slip form is near its end.
        bool SlpNearEnd { get; }
        //
        // Summary:
        //     Gets the side of the slip print station document on which printing will occur.
        PrinterSide SlpPrintSide { get; }
        //
        // Summary:
        //     Gets the maximum number of characters that can be printed on each line in
        //     sideways mode.
        int SlpSidewaysMaxChars { get; }
        //
        // Summary:
        //     Gets the maximum number of lines that can be printed in sideways mode.
        int SlpSidewaysMaxLines { get; }

        // Summary:
        //     Queued by the service object when an error is detected and the device’s State
        //     transitions into the error state.
        event Windows.Foundation.TypedEventHandler<PosPrinter, DeviceErrorEventArgs> ErrorEvent;
        //
        // Summary:
        //     Queued by the service object to notify the application when asynchronous
        //     processing that corresponds to an OutputID has successfully completed.
        //event OutputCompleteEventHandler OutputCompleteEvent;

        // Summary:
        //     Starts form insertion processing. BeginInsertion is paired with the EndInsertion
        //     method to control form insertion.
        //
        // Parameters:
        //   timeout:
        //     The timeout parameter gives the number of milliseconds before failing the
        //     method.
        IAsyncOperation<int> BeginInsertion(int timeout);
        //
        // Summary:
        //     Starts form removal processing.
        //
        // Parameters:
        //   Timeout:
        //     The timeout parameter gives the number of milliseconds before failing the
        //     method.
        IAsyncOperation<int> BeginRemoval(int timeout);
        //
        // Summary:
        //     Selects the side of the document that it wants to print on.
        //
        // Parameters:
        //   Side:
        //     The side parameter indicates the side of the document where printing will
        //     occur. Possible values are defined by the PrintSide enumeration.
        void ChangePrintSide(PrinterSide side);
        //
        // Summary:
        //     Clears all device output that has been buffered. Also, when it is possible,
        //     stops outputs that are in progress.
        void ClearOutput();
        //
        // Summary:
        //     Clears the area defined by the PageModePrintArea property.
        void ClearPrintArea();
        //
        // Summary:
        //     Cuts the receipt paper.
        //
        // Parameters:
        //   percentage:
        //     The percentage parameter indicates the percentage of paper to cut. If percentage
        //     is set to the constant PrinterCutPaperFullCut, this causes a full paper cut.
        //     Other percentage values request a partial cut.
        void CutPaper(int percentage);
        void DrawRuledLine(PrinterStation station, string positionList, LineDirection direction, int lineWidth, LineStyle style, int lineColor);
        //
        // Summary:
        //     Ends form-insertion processing.
        void EndInsertion();
        //
        // Summary:
        //     Ends form-removal processing.
        void EndRemoval();
        //
        // Summary:
        //     Uses the printer’s mark sensor for receipt paper.
        //
        // Parameters:
        //   Type:
        //     The type parameter indicates the kind of mark-sensed paper handling. Possible
        //     values are defined by the PrinterMarkFeeds enumeration.
        void MarkFeed(PrinterMarkFeeds type);
        //
        // Summary:
        //     Starts or exits Page Mode for the station specified in the PageModeStation
        //     property.
        //
        // Parameters:
        //   control:
        //     The Page Mode control.
        void PageModePrint(PageModePrintControl control);
        //
        // Summary:
        //     Prints a bar code on the specified printer station.
        //
        // Parameters:
        //   data:
        //     Character string to be bar-coded.
        //
        //   width:
        //     Bar code width. Expressed in the unit of measure indicated by the MapMode
        //     property.
        //
        //   height:
        //     Bar code height. Expressed in the unit of measure indicated by the MapMode
        //     property.
        //
        //   symbology:
        //     Bar code symbol type to use. Possible values are defined by the BarCodeSymbology
        //     enumeration.
        //
        //   textPosition:
        //     Placement of the readable character string. Possible values are defined by
        //     the BarCodeTextPosition enumeration.
        //
        //   alignment:
        //     Placement of the bar code. For possible values, see Remarks in this topic.
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are PrinterStation.Receipt or PrinterStation.Slip.
        void PrintBarCode(PrinterStation station, string data, BarCodeSymbology symbology, int height, int width, int alignment, BarCodeTextPosition textPosition);
        //
        // Summary:
        //     Prints a bitmap on the specified printer station.
        //
        // Parameters:
        //   fileName:
        //     Name of Windows bitmap file. The file must be in uncompressed format.
        //
        //   width:
        //     Printed width of the bitmap to be performed. See Remarks in this topic.
        //
        //   alignment:
        //     Placement of the bitmap. For possible values, see Remarks in this topic.
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are PrinterStation.Receipt or PrinterStation.Slip.
        void PrintBitmap(PrinterStation station, string fileName, int width, int alignment);
        //
        // Summary:
        //     Prints the string immediately that is specified for data on the printer station
        //     specified by station.
        //
        // Parameters:
        //   data:
        //     The characters to be printed. May consist of printable characters, escape
        //     sequences, carriage returns (13 decimal), and new line / line feed (10 decimal).
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are as follows: PrinterStation.Journal, PrinterStation.Receipt,
        //     or PrinterStation.Slip.
        void PrintImmediate(PrinterStation station, string data);
        //
        // Summary:
        //     Prints a bitmap from memory on the specified printer station.
        //
        // Parameters:
        //   data:
        //     The bitmap to be printed.
        //
        //   width:
        //     Printed width of the bitmap.
        //
        //   alignment:
        //     Placement of the bitmap.
        //
        //   station:
        //     The printer station to be used. Can be either PrinterStation.Slip or PrinterStation.Receipt.
        //void PrintMemoryBitmap(PrinterStation station, System.Drawing.Bitmap data, int width, int alignment);
        //
        // Summary:
        //     Prints the string specified in data on the printer station specified in station.
        //
        // Parameters:
        //   data:
        //     The characters to be printed. May consist of printable characters, escape
        //     sequences, carriage returns (13 decimal), and new line / line feed (10 decimal).
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are as follows: PrinterStation.Journal, PrinterStation.Receipt,
        //     or PrinterStation.Slip.
        void PrintNormal(PrinterStation station, string data);
        //
        // Summary:
        //     Prints two strings on two print stations concurrently. When supported, this
        //     may give increased print performance.
        //
        // Parameters:
        //   stations:
        //     The printer stations to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are as follows: PrinterStation.TwoReceiptJournal,
        //     PrinterStation.TwoSlipJournal, or PrinterStation.TwoSlipReceipt.
        //
        //   data2:
        //     The characters to be printed on the second station. (Restrictions are the
        //     same as data1.) If this string is the empty string (""), then print the same
        //     data as data1. On some printers, by using this format may give additional
        //     increased print performance.
        //
        //   data1:
        //     The characters to be printed on the first station. May consist of printable
        //     characters and escape sequences as listed in the PosPrinter topic. The characters
        //     must all fit on one printed line so that the printer may try to print on
        //     both stations concurrently.
        void PrintTwoNormal(PrinterStation stations, string data1, string data2);
        //
        // Summary:
        //     Enters or exits rotated print mode.
        //
        // Parameters:
        //   rotation:
        //     Direction of rotation. Possible values are defined by the PrintRotation enumeration.
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are as follows: PrinterStation.Receipt or PrinterStation.Slip.
        void RotatePrint(PrinterStation station, PrintRotation rotation);
        //
        // Summary:
        //     Saves information about a bitmap for later printing.
        //
        // Parameters:
        //   fileName:
        //     Name of Windows bitmap file. The file must be in uncompressed format. If
        //     set to an empty string (""), the bitmap is unset.
        //
        //   width:
        //     Printed width of the bitmap to be performed. See the PrintBitmap method for
        //     values.
        //
        //   bitmapNumber:
        //     The number to be assigned to this bitmap. Two bitmaps, numbered 1 and 2,
        //     may be set.
        //
        //   alignment:
        //     Placement of the bitmap.
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are as follows: PrinterStation.Receipt or PrinterStation.Slip.
        void SetBitmap(int bitmapNumber, PrinterStation station, string fileName, int width, int alignment);
        //
        // Summary:
        //     Saves a data string as the top or bottom logo.
        //
        // Parameters:
        //   data:
        //     The characters that produce the logo. May consist of printable characters,
        //     escape sequences, carriage returns (13 decimal), and newline / line feed
        //     (10 decimal).
        //
        //   location:
        //     Where the logo is to be set. Possible values are defined by the PrinterLogoLocation
        //     enumeration as PrinterLogoLocation.Top or PrinterLogoLocation.Bottom.
        void SetLogo(PrinterLogoLocation location, string data);
        //
        // Summary:
        //     Enters or exits transaction mode.
        //
        // Parameters:
        //   control:
        //     Transaction control. Possible values are defined by the PrinterTransactionControl
        //     enumeration. See in this topic.
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are as follows: PrinterStation.Journal, PrinterStation.Receipt,
        //     or PrinterStation.Slip.
        void TransactionPrint(PrinterStation station, PrinterTransactionControl control);
        //
        // Summary:
        //     Determines whether a data sequence, possibly including one or more escape
        //     sequences, is valid for the specified station, before it calls the PrintImmediate,
        //     PrintNormal, or PrintTwoNormal methods.
        //
        // Parameters:
        //   data:
        //     The data to be validated. May include printable data and escape sequences.
        //     See Remarks in this topic.
        //
        //   station:
        //     The printer station to be used. Possible values are defined by the PrinterStation
        //     enumeration. Valid values are as follows: PrinterStation.Journal, PrinterStation.Receipt,
        //     or PrinterStation.Slip.
        void ValidateData(PrinterStation station, string data);
    }
}
