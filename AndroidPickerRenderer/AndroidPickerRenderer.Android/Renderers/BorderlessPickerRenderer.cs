using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidPickerRenderer.Controls;
using AndroidPickerRenderer.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderlessPicker), typeof(BorderlessPickerRenderer))]
namespace AndroidPickerRenderer.Droid.Renderers
{
    public class BorderlessPickerRenderer : Xamarin.Forms.Platform.Android.AppCompat.PickerRenderer
    {
        public BorderlessPickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}