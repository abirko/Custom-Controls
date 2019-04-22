using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CustomControls;
using CustomControls.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(ShadedButton), typeof(ShadedButtonRenderer))]
namespace CustomControls.iOS
{
    public class ShadedButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.BackgroundColor = UIColor.Gray;
            }
        }
    }
}