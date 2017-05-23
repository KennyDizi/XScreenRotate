using System.ComponentModel;
using Android.Content.PM;
using xfrotate;
using xfrotate.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomContentPage), typeof(CustomContentPageRenderer))]

namespace xfrotate.Droid
{
    public class CustomContentPageRenderer : PageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            var page = Element as CustomContentPage;
            if (page != null)
            {
                var activity = Forms.Context as MainActivity;
                if (activity != null)
                {
                    activity.RequestedOrientation = page.RequestLandScapeView
                        ? ScreenOrientation.SensorLandscape
                        : ScreenOrientation.SensorPortrait;
                }
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName.Equals(CustomContentPage.RequestLandScapeViewProperty.PropertyName))
            {
                var page = Element as CustomContentPage;
                if (page != null)
                {
                    var activity = Forms.Context as MainActivity;
                    if (activity != null)
                    {
                        activity.RequestedOrientation = page.RequestLandScapeView
                            ? ScreenOrientation.SensorLandscape
                            : ScreenOrientation.SensorPortrait;
                    }
                }
            }
        }
    }
}