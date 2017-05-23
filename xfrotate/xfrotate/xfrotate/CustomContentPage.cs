using Xamarin.Forms;

namespace xfrotate
{
    public class CustomContentPage : ContentPage
    {
        #region properties

        public bool RequestLandScapeView
        {
            get => (bool) GetValue(RequestLandScapeViewProperty);
            set => SetValue(RequestLandScapeViewProperty, value);
        }

        public static readonly BindableProperty RequestLandScapeViewProperty =
            BindableProperty.Create(nameof(RequestLandScapeView), typeof(bool), typeof(CustomContentPage),
                defaultValue: false);

        #endregion
    }
}