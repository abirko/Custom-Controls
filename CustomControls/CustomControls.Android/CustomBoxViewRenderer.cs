using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using CustomControls;
using CustomControls.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRendererAttribute(typeof(CustomBoxView), typeof(CustomBoxViewRenderer))]
namespace CustomControls.Droid
{
    public class CustomBoxViewRenderer :  BoxRenderer
    {
        public CustomBoxViewRenderer(Context context) : base(context)
        {
            SetWillNotDraw(false);
        }

        public override void Draw(Android.Graphics.Canvas canvas)
        {


            base.Draw(canvas);

            CustomBoxView specialBoxView = (CustomBoxView)Element;

            Rect rect = new Rect();
            GetDrawingRect(rect);

            Rect inside = rect;
            inside.Inset((int)specialBoxView.BorderThickness, (int)specialBoxView.BorderThickness);

            Paint p = new Paint();
            p.Color = specialBoxView.Color.ToAndroid();

            canvas.DrawRect(inside, p);

            p.Color = specialBoxView.BorderColor.ToAndroid();
            p.StrokeWidth = (float)specialBoxView.BorderThickness;
            p.SetStyle(Paint.Style.Stroke);

            canvas.DrawRect(rect, p);
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Invalidate();

        }

    }
}