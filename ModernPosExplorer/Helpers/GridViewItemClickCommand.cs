// Brokered Point of Service ver. 1.0
// Copyright (c) Microsoft Corporation
// All rights reserved. 
// MIT License
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ""Software""), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
// THE SOFTWARE IS PROVIDED *AS IS*, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
using System.Windows.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ModernPosExplorer.Helpers
{
    // Courtesy of: http://geoffwebbercross.blogspot.com/2012/05/windows-8-metro-gridview-itemclick.html
    public class GridViewItemClickCommand
    {
        #region Command Attached Dependency Property
        public static readonly DependencyProperty CommandProperty =
            DependencyProperty.RegisterAttached("Command", typeof(ICommand), typeof(GridViewItemClickCommand), new PropertyMetadata(null, CommandPropertyChanged));

        public static void SetCommand(DependencyObject attached, ICommand value)
        {
            attached.SetValue(CommandProperty, value);
        }

        public static ICommand GetCommand(DependencyObject attached)
        {
            return (ICommand)attached.GetValue(CommandProperty);
        }

        private static void CommandPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Attach click handler
            (d as GridView).ItemClick += gridView_ItemClick;
        }

        private static void gridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Get GridView
            var gridView = (sender as GridView);

            // Get command
            ICommand command = GetCommand(gridView);

            // Execute command
            command.Execute(e.ClickedItem);
        }
        #endregion
    }
}
