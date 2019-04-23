using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomControls
{
    public class CustomBoxView : BoxView 
    {
        public static readonly BindableProperty BorderColorProperty =
         BindableProperty.Create<CustomBoxView, Color>(
             p => p.BorderColor, default(Color));

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }

        public static readonly BindableProperty BorderThicknessProperty =
            BindableProperty.Create<CustomBoxView, double>(
                p => p.BorderThickness, default(double));

        public double BorderThickness
        {
            get { return (double)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }
    }
}
