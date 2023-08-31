namespace GetYakking
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            FadeInWelcomeMessage();
        }

        private async void FadeInWelcomeMessage()
        {
            await WelcomeGrid.FadeTo(1, 2000); // Fade in over 2 seconds
            await Task.Delay(5000); // Wait for 20 seconds
            await WelcomeGrid.FadeTo(0, 1000); // Fade out over 2 seconds
            WelcomeGrid.IsVisible = false;

            FadeInWelcomeMessage2();
        }

        private async void FadeInWelcomeMessage2()
        {
            WelcomeGrid2.IsVisible = true;
            await WelcomeGrid2.FadeTo(1, 1000); // Fade in over 2 seconds
            await Task.Delay(5000); // Wait for 20 seconds
            await WelcomeGrid2.FadeTo(0, 1000); // Fade out over 2 seconds
            WelcomeGrid2.IsVisible = false;

            FadeInWelcomeMessage3();
        }

        private async void FadeInWelcomeMessage3()
        {
            WelcomeGrid3.IsVisible = true;
            await WelcomeGrid3.FadeTo(1, 1000); // Fade in over 2 seconds
            await Task.Delay(5000); // Wait for 20 seconds
            await WelcomeGrid3.FadeTo(0, 1000); // Fade out over 2 seconds
            WelcomeGrid3.IsVisible = false;

            FadeInWelcomeMessage4();
        }

        private async void FadeInWelcomeMessage4()
        {
            WelcomeGrid4.IsVisible = true;
            await WelcomeGrid4.FadeTo(1, 1000); // Fade in over 2 seconds
            await Task.Delay(5000); // Wait for 20 seconds
            await WelcomeGrid4.FadeTo(0, 2000); // Fade out over 2 seconds
            WelcomeGrid4.IsVisible = false;
        }

    }
}
