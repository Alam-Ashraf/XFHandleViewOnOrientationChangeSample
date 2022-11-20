using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFHandleViewOnOrientationChangeSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width > height)
            {
                // Landscape
                VisualStateManager.GoToState(FlexLayout, "Landscape");
            }
            else
            {
                // Portrait
                VisualStateManager.GoToState(FlexLayout, "Portrait");
            }
        }
    }
}

