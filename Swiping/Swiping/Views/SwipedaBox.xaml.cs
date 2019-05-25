using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swiping.Views
{
    public class SwipedBoxViewModel
    {
        public Command SwipeCommandL { get; private set; }
        public Command SwipeCommandT { get; private set; }
        public Command SwipeCommandR { get; private set; }
        public Command SwipeCommandB { get; private set; }

        public SwipedBoxViewModel()
        {
            SwipeCommandL = new Command(HandleSwipeActionL);
            SwipeCommandT = new Command(HandleSwipeActionT);
            SwipeCommandR = new Command(HandleSwipeActionR);
            SwipeCommandB = new Command(HandleSwipeActionB);
        }

        private async void HandleSwipeActionL()
        {
            await Application.Current.MainPage.DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture Left to Right!", "Close");
        }
        private async void HandleSwipeActionT()
        {
            await Application.Current.MainPage.DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture Top to Bottom!", "Close");
        }
        private async void HandleSwipeActionR()
        {
            await Application.Current.MainPage.DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture Right to Left!", "Close");
        }
        private async void HandleSwipeActionB()
        {
            await Application.Current.MainPage.DisplayAlert("Swiper No Swiping!", "Yay! You successfully used the swipe gesture!Bottom to Top", "Close");
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwipedaBox
    {
        public SwipedaBox()
        {
            InitializeComponent();

            Content.BindingContext = new SwipedBoxViewModel();
        }

        private async void TappedSquare(object sender, EventArgs e)
        {
            await Application.Current.MainPage.DisplayAlert("Tapper No Tapping!", "Yay! You successfully used the Tap gesture!", "Close");

        }
    }
}