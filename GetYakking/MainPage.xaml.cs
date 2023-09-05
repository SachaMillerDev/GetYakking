namespace GetYakking
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                // Code to flip the card and reveal the "test placeholder"
            };
            VirtualCard.GestureRecognizers.Add(tapGestureRecognizer);
            FadeInWelcomeMessage();
        }

        private async void FadeInWelcomeMessage()
        {
            await WelcomeGrid.FadeTo(1, 2000);
            await Task.Delay(5000);
            await WelcomeGrid.FadeTo(0, 1000);
            WelcomeGrid.IsVisible = false;
            FadeInWelcomeMessage2();
        }

        private async void FadeInWelcomeMessage2()
        {
            WelcomeGrid2.IsVisible = true;
            await WelcomeGrid2.FadeTo(1, 1000);
            await Task.Delay(5000);
            await WelcomeGrid2.FadeTo(0, 1000);
            WelcomeGrid2.IsVisible = false;
            FadeInWelcomeMessage3();
        }

        private async void FadeInWelcomeMessage3()
        {
            WelcomeGrid3.IsVisible = true;
            await WelcomeGrid3.FadeTo(1, 1000);
            await Task.Delay(5000);
            await WelcomeGrid3.FadeTo(0, 1000);
            WelcomeGrid3.IsVisible = false;
            FadeInWelcomeMessage4();
        }

        private async void FadeInWelcomeMessage4()
        {
            WelcomeGrid4.IsVisible = true;
            await WelcomeGrid4.FadeTo(1, 1000);
            await Task.Delay(5000);
            await WelcomeGrid4.FadeTo(0, 2000);
            WelcomeGrid4.IsVisible = false;
            // Added this line to go back to the first welcome message
            FadeInWelcomeMessage();
        }
    }
}
