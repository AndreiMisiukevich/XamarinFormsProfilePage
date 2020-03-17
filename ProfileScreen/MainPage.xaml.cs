using System.ComponentModel;
using System.Linq;
using System.Threading;
using Xamarin.Forms;
using static System.Math;

namespace ProfileScreen
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private bool _isSocialOpened;
        private CancellationTokenSource _tokenSource;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnTabsSizeChanged(object sender, System.EventArgs e)
        {
            //TabsLayout.BindingContext = null;
            TabsLayout.BindingContext = InfoLayout;
            Tabs.GetType().GetMethod("UpdateStripePosition", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).Invoke(Tabs, null);
        }

        private void OnRootScrollViewScrolled(object sender, ScrolledEventArgs e)
        {
            var position = EmptyLayout.Height + Max(0, RootScrollView.ScrollY - EmptyLayout.Height);
            AbsoluteLayout.SetLayoutBounds(TabsLayout, new Rectangle(0, position, 1, TabsLayout.Height));

            var opacity = Max(0, Min(RootScrollView.ScrollY, EmptyLayout.Height)) / EmptyLayout.Height - 0.1;
            ImageOverlay.Opacity = Min(1, Max(0, opacity));
            EmptyLayout.Opacity = 1 - ImageOverlay.Opacity;

            EmptyLayout.Scale = RootScrollView.ScrollY < 0
                ? 1 - RootScrollView.ScrollY / EmptyLayout.Height
                : 1; ;

            EmptyLayout.TranslationX = ImageOverlay.Opacity * 25;

            Picture.TranslationY = -ImageOverlay.Opacity * 100;

            Picture.Scale = RootScrollView.ScrollY < 0
                ? 1 - RootScrollView.ScrollY / EmptyLayout.Height * 2
                : 1;
        }

        private void OnSocialClicked(VisualElement sender, TouchEffect.EventArgs.TouchCompletedEventArgs args)
        {
            _tokenSource?.Cancel();
            _tokenSource = new CancellationTokenSource();
            var token = _tokenSource.Token;
            _isSocialOpened = !_isSocialOpened;
            var firstSocial = FirstSocial;
            var thirdSocial = ThirdSocial;
            if (_isSocialOpened)
            {
                firstSocial = ThirdSocial;
                thirdSocial = FirstSocial;
            }

            Device.BeginInvokeOnMainThread(async () =>
            {
                await firstSocial.ScaleTo(_isSocialOpened ? 1 : 0);
                if (token.IsCancellationRequested) return;
                await SecondSocial.ScaleTo(_isSocialOpened ? 1 : 0);
                if (token.IsCancellationRequested) return;
                await thirdSocial.ScaleTo(_isSocialOpened ? 1 : 0);
            });
        }

        private void OnSocialPicked(VisualElement sender, TouchEffect.EventArgs.TouchCompletedEventArgs args)
        {
            var webView = new WebView();
            var page = new ContentPage { Content = webView };
            switch (args.Parameter) {
                case "twitter":
                    webView.Source = (BindingContext as MainViewModel)?.Twitter;
                    page.Title = "Twitter";
                    break;
                case "linkedin":
                    webView.Source = (BindingContext as MainViewModel)?.LinkedIn;
                    page.Title = "LinkedIn";
                    break;
                case "instagram":
                    webView.Source = (BindingContext as MainViewModel)?.Instagram;
                    page.Title = "Instagram";
                    break;
            }
            OnSocialClicked(null, null);
            Navigation.PushAsync(page);
        }

        private async void ItemAppeared(PanCardView.CardsView view, PanCardView.EventArgs.ItemAppearedEventArgs args)
        {
            if(view.SelectedIndex == 1)
            {
                await RootScrollView.ScrollToAsync(EmptyLayout, ScrollToPosition.Start, true);
                view.ForceLayout();
            }
        }
    }
}
