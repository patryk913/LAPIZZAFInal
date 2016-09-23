using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LAPIZZA
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

		/*Button navigation to Order Page*/
        private async void NavigateButtonOrder(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderPage().GetSampleContentPage());
        }

		/*Button navigation to About Us Page*/
        private async void NavigateButtonAboutUs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutUsPage());
        }

		/*Button navigation to Contact Us Page*/
        private async void NavigateButtonContactUs(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactUsPage());
        }

		/*Button navigation to Order History Page*/
        private async void NavigateButtonOrderHist(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OrderHistoryPage().GetHistoryContentPage());
        }
    }
}
