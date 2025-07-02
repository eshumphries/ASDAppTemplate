using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
// Add this to use ScaleTransform
using Windows.UI.Xaml.Media;

namespace ASDAppTemplate
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            // Create the method to change page element size according to page size
            DisplayScrollViewer.SizeChanged += DisplayScrollViewer_SizeChanged;
        }
        private void DisplayScrollViewer_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Store the right screen size
            double scale = Math.Min(e.NewSize.Width / 800, e.NewSize.Height / 600);
            // Scale it just right
            DisplayGrid.RenderTransform = new ScaleTransform
            {
                ScaleX = scale * 1.8,
                ScaleY = scale * 1.8
            };
        }
    }
}
