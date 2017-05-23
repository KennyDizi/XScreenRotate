using UIKit;
using xfrotate;
using xfrotate.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomContentPage), typeof(CustomContentPageRenderer))]

namespace xfrotate.iOS
{
    public class CustomContentPageRenderer : PageRenderer
    {
        private bool _requestLandscape;

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            var page = Element as CustomContentPage;
            if (page != null && page.RequestLandScapeView)
                _requestLandscape = true;
        }        

        public override void ViewWillAppear(bool animated)
        {
            UIApplication.SharedApplication.SetStatusBarOrientation(
                _requestLandscape
                    ? UIInterfaceOrientation.LandscapeLeft
                    : UIInterfaceOrientation.Portrait, animated: true);

            base.ViewWillAppear(animated);
        }

        public override bool ShouldAutorotate()
        {
            return true;
        }

        public override bool ShouldAutorotateToInterfaceOrientation(UIInterfaceOrientation interfaceOrientation)
        {
            if (_requestLandscape)
                return interfaceOrientation == UIInterfaceOrientation.LandscapeLeft ||
                       interfaceOrientation == UIInterfaceOrientation.LandscapeRight;

            return interfaceOrientation == UIInterfaceOrientation.Portrait ||
                   interfaceOrientation == UIInterfaceOrientation.PortraitUpsideDown;
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations()
        {
            return _requestLandscape
                ? UIInterfaceOrientationMask.Landscape
                : UIInterfaceOrientationMask.Portrait;
        }
    }
}