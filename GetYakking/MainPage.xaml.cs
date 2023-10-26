using System;
using Microsoft.Maui.Controls;

namespace GetYakking;

public partial class MainPage : ContentPage
{
    private bool isCardFlipped = false;

    public MainPage()
    {
        InitializeComponent();
        var tapGestureRecognizer = new TapGestureRecognizer();
        tapGestureRecognizer.Tapped += (s, e) => {
            FlipCard();
        };
        VirtualCard.GestureRecognizers.Add(tapGestureRecognizer);
        FadeInWelcomeMessage();

        // Add tap gesture recognizers to welcome grids to make them skippable
        var skipIntroGesture = new TapGestureRecognizer();
        skipIntroGesture.Tapped += (s, e) => {
            SkipIntro();
        };
        WelcomeGrid.GestureRecognizers.Add(skipIntroGesture);
        WelcomeGrid2.GestureRecognizers.Add(skipIntroGesture);
        WelcomeGrid3.GestureRecognizers.Add(skipIntroGesture);
        WelcomeGrid4.GestureRecognizers.Add(skipIntroGesture);
    }

    private void FlipCard()
    {
        isCardFlipped = !isCardFlipped;
        if (isCardFlipped)
        {
            CardImage.IsVisible = false;
            CardLabel.IsVisible = true;
            CardLabel.Text = "Back";
        }
        else
        {
            CardImage.IsVisible = true;
            CardLabel.IsVisible = false;
        }
    }

    private async void FadeInWelcomeMessage()
    {
        VirtualCard.IsVisible = false;
        WelcomeGrid.IsVisible = true;
        await WelcomeGrid.FadeTo(1, 2000);
        await Task.Delay(5000);
        await WelcomeGrid.FadeTo(0, 1000);
        WelcomeGrid.IsVisible = false;
        VirtualCard.IsVisible = true;
        FadeInWelcomeMessage2();
    }

    private async void FadeInWelcomeMessage2()
    {
        VirtualCard.IsVisible = false;
        WelcomeGrid2.IsVisible = true;
        await WelcomeGrid2.FadeTo(1, 1000);
        await Task.Delay(5000);
        await WelcomeGrid2.FadeTo(0, 1000);
        WelcomeGrid2.IsVisible = false;
        VirtualCard.IsVisible = true;
        FadeInWelcomeMessage3();
    }

    private async void FadeInWelcomeMessage3()
    {
        VirtualCard.IsVisible = false;
        WelcomeGrid3.IsVisible = true;
        await WelcomeGrid3.FadeTo(1, 1000);
        await Task.Delay(5000);
        await WelcomeGrid3.FadeTo(0, 1000);
        WelcomeGrid3.IsVisible = false;
        VirtualCard.IsVisible = true;
        FadeInWelcomeMessage4();
    }

    private async void FadeInWelcomeMessage4()
    {
        VirtualCard.IsVisible = false;
        WelcomeGrid4.IsVisible = true;
        await WelcomeGrid4.FadeTo(1, 1000);
        await Task.Delay(5000);
        await WelcomeGrid4.FadeTo(0, 2000);
        WelcomeGrid4.IsVisible = false;
        VirtualCard.IsVisible = true;
    }

    private void ShowRules(object sender, EventArgs e)
    {
        VirtualCard.IsVisible = false;
        WelcomeGrid.IsVisible = true;
        FadeInWelcomeMessage();
    }

    // New method to skip the intro
    private void SkipIntro()
    {
        WelcomeGrid.IsVisible = false;
        WelcomeGrid2.IsVisible = false;
        WelcomeGrid3.IsVisible = false;
        WelcomeGrid4.IsVisible = false;
        VirtualCard.IsVisible = true;
    }
}
