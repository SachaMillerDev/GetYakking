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
            await Task.Delay(10000); // Wait for 20 seconds
            await WelcomeGrid.FadeTo(0, 2000); // Fade out over 2 seconds
            WelcomeGrid.IsVisible = false;
        }
    }
}
