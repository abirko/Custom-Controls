using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using CoreGraphics;
using CustomControls.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRendererAttribute(typeof(BoxRenderer), typeof(CustomBoxViewRenderer))]
namespace CustomControls.iOS
{
    public class CustomBoxViewRenderer : BoxRenderer
    {
        /* */
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            CustomBoxView boxView = (CustomBoxView)Element; 
            using( var context = UIGraphics.GetCurrentContext()) //using bloc to set the context 
            {
                context.SetFillColor(boxView.Color.ToCGColor()); //fill color 
                context.SetStrokeColor(boxView.BorderColor.ToCGColor()); //border color 
                context.SetLineWidth((float)boxView.BorderThikness); //width of border 
                var rectangle = Bounds.Inset((int)boxView.BorderThikness, 
                    (int)boxView.BorderThikness); //
                var path = CGPath.FromRect(rectangle);
                context.AddPath(path);
                context.DrawPath(CGPathDrawingMode.FillStroke);
            }
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == CustomBoxView.BorderThiknessProperty.PropertyName)
            {
                SetNeedsDisplay();
            }
        }
    }
}