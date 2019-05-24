using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiping.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipedaBox : ContentPage
    {
        public string Url { get; private set; } = "xamarin.com";

        public Command TapCommand { get; private set; }

        public Command SwipeCommandL { get; private set; }
        public Command SwipeCommandT { get; private set; }
        public Command SwipeCommandR { get; private set; }
        public Command SwipeCommandB { get; private set; }

        public SwipedaBox()
        {
            InitializeComponent();
            SwipeCommandL = new Command(HandleSwipeActionL);
            SwipeCommandT = new Command(HandleSwipeActionT);
            SwipeCommandR = new Command(HandleSwipeActionR);
            SwipeCommandB = new Command(HandleSwipeActionB);

            BindingContext = this;
        }


        private async void HandleSwipeActionL()
        {
            await DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture Left to Right!", "Close");
        }
        private async void HandleSwipeActionT()
        {
            await DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture Top to Bottom!", "Close");
        }
        private async void HandleSwipeActionR()
        {
            await DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture Right to Left!", "Close");
        }
        private async void HandleSwipeActionB()
        {
            await DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture!Bottom to Top", "Close");
        }

        private async void TappedSquare(object sender, EventArgs e)
        {
            await DisplayAlert("Tapper No Tapping!", "Yay! You successfully used the Tap gesture!", "Close");

        }
    }
}