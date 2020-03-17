using Xamarin.Forms;

namespace ProfileScreen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = (Color)Resources["NavigationBarColor"],
                BarTextColor = (Color)Resources["BackgroundColor"]
            };
        }
    }
}
