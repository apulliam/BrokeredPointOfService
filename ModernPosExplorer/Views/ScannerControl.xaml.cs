using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using ModernPosExplorer.ViewModels;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace ModernPosExplorer.Views
{
    public sealed partial class ScannerControl : UserControl
    {
        private ScannerViewModel scannerViewModel = new ScannerViewModel();

        public ScannerViewModel ScannerViewModel
        {
            get { return this.scannerViewModel; }
        }

        public ScannerControl()
        {
            this.InitializeComponent();
        }
    }
}
