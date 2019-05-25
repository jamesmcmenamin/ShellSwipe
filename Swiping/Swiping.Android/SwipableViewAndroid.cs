using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Swiping.Controls;
using Swiping.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly:ExportRenderer(typeof(SwiperMamba),typeof(SwipableViewAndroid))]
namespace Swiping.Droid
{
    public class SwipableViewAndroid : ViewRenderer
    {
        public static void Init() { }
        public override bool DispatchTouchEvent(MotionEvent e)
        {
            Parent.RequestDisallowInterceptTouchEvent(true);
            return base.DispatchTouchEvent(e);
        }
        public SwipableViewAndroid(Context context) : base(context)
        {
        }

    }
}
