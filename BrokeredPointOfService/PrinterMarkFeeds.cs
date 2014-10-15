using System;

namespace BrokeredPointOfService
{
    // Summary:
    //     Enumerates the possible kinds of mark-sensed paper handling.
    //  None                                      = 0     Does not feed.
    //  Takeup                                    = 1     Feeds the mark-sensed paper to the paper take-up position.
    //  Cutter                                    = 2     Feeds the mark-sensed paper to the auto cutter cutting position.
    //  TakeupCutter                              = 3
    //  CurrentTopOfForm                          = 4     Feeds the mark-sensed paper to the present paper’s top of form. (Reverse
    //                                                     feed if it is required).
    //  TakeupCurrentTopOfForm                    = 5
    //  CutterCurrentTopOfForm                    = 6
    //  TakeupCutterCurrentTopOfForm              = 7
    //  NextTopOfForm                             = 8     Feeds the mark-sensed paper to the next paper’s top of form.
    //  TakeupNextTopOfForm                       = 9
    //  CutterNextTopOfForm                       = 10
    //  TakeUpCutterNextTopOfForm                 = 11
    //  CurrentTopOfFormNextTopOfForm             = 12
    //  TakeupCurrentTopOfFormNextTopOfForm       = 13
    //  CutterCurrentTopOfFormNextTopOfForm       = 14
    //  TakeupCutterCurrentTopOfFormNextTopOfForm = 15

    public sealed class PrinterMarkFeeds : Enumeration
    {
        internal Microsoft.PointOfService.PrinterMarkFeeds InternalPrinterMarkFeeds { get; set; }

        internal PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds printerMarkFeeds)
        {
            InternalPrinterMarkFeeds = printerMarkFeeds;
        }

        // Summary:
        //     Does not feed.
        public static PrinterMarkFeeds None
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.None);
            }
        }

        //
        // Summary:
        //     Feeds the mark-sensed paper to the paper take-up position.
        public static PrinterMarkFeeds Takeup
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup);
            }
        }

        //
        // Summary:
        //     Feeds the mark-sensed paper to the auto cutter cutting position.
        public static PrinterMarkFeeds Cutter
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Cutter);
            }
        }

        public static PrinterMarkFeeds TakeupCutter
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup |
                                            Microsoft.PointOfService.PrinterMarkFeeds.Cutter);
            }
        }

        //
        // Summary:
        //     Feeds the mark-sensed paper to the present paper’s top of form. (Reverse
        //     feed if it is required).
        public static PrinterMarkFeeds CurrentTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm);
            }
        }

        public static PrinterMarkFeeds TakeupCurrentTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup |
                                            Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm);
            }
        }

        public static PrinterMarkFeeds CutterCurrentTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Cutter |
                                            Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm);
            }
        }

        public static PrinterMarkFeeds TakeupCutterCurrentTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup |
                                            Microsoft.PointOfService.PrinterMarkFeeds.Cutter | 
                                            Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm);
            }
        }


        //
        // Summary:
        //     Feeds the mark-sensed paper to the next paper’s top of form.
        public static PrinterMarkFeeds NextTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public static PrinterMarkFeeds TakeupNextTopOfForm 
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup |
                                            Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public static PrinterMarkFeeds CutterNextTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Cutter |
                                            Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public static PrinterMarkFeeds TakeUpCutterNextTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup |
                                            Microsoft.PointOfService.PrinterMarkFeeds.Cutter |
                                            Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public static PrinterMarkFeeds CurrentTopOfFormNextTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm |
                                            Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public static PrinterMarkFeeds TakeupCurrentTopOfFormNextTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup |
                                            Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm |
                                            Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public static PrinterMarkFeeds CutterCurrentTopOfFormNextTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Cutter |
                                            Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm |
                                            Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public static PrinterMarkFeeds TakeupCutterCurrentTopOfFormNextTopOfForm
        {
            get
            {
                return new PrinterMarkFeeds(Microsoft.PointOfService.PrinterMarkFeeds.Takeup |
                                            Microsoft.PointOfService.PrinterMarkFeeds.Cutter |
                                            Microsoft.PointOfService.PrinterMarkFeeds.CurrentTopOfForm |
                                            Microsoft.PointOfService.PrinterMarkFeeds.NextTopOfForm);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            PrinterMarkFeeds other = (PrinterMarkFeeds)obj;
            return this.InternalPrinterMarkFeeds.Equals(other.InternalPrinterMarkFeeds);
        }

        public override int GetHashCode()
        {
            return InternalPrinterMarkFeeds.GetHashCode();
        }

        public override string ToString()
        {
            return InternalPrinterMarkFeeds.ToString();
        }

        public int Value
        {
            get
            {
                return (int)InternalPrinterMarkFeeds;
            }
        }

    }
}