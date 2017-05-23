using System;

namespace xfrotate
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void GoToPotraitPage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new NormalPotraitContentPage());
        }

        private void GoToLandScapePage(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new NormalLandscapeContentPage());
        }
    }
}
