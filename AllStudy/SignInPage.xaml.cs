using System.Globalization;
using Microsoft.Maui.Graphics;
using System.Threading.Tasks;

namespace AllStudy;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
        this.BackgroundColor = Color.FromArgb("#F0F5F9");
        this.Loaded += OnPageLoaded;
    }

    private async void OnPageLoaded(object sender, EventArgs e)
    {
        // Set initial opacity to 0 for the images and buttons
        logoImage.Opacity = 0;
        computerImage.Opacity = 0;
        signInButton.Opacity = 0;
        signUpButton.Opacity = 0;
        greetingLabel.IsVisible = true;  // Make the greeting label visible
        greetingLabel.Opacity = 0; // Set initial opacity for the greeting label

        // Fade in the greeting message
        await greetingLabel.FadeTo(1, 800, Easing.CubicInOut);

        // Wait for 2 seconds
        await Task.Delay(2000);

        // Fade out the greeting message
        await greetingLabel.FadeTo(0, 800, Easing.CubicInOut);
        greetingLabel.IsVisible = false; // Hide the label after fading out

        // Perform fade animations for logo and buttons
        await Task.WhenAll(
            logoImage.FadeTo(1, 800, Easing.CubicInOut),
            computerImage.FadeTo(1, 1000, Easing.CubicInOut),
            signInButton.FadeTo(1, 1200, Easing.CubicInOut),
            signUpButton.FadeTo(1, 1400, Easing.CubicInOut)
        );
    }

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is double height)
        {
            return height / 2;
        }
        return 0;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    private void SignInButtonClicked(object sender, EventArgs e)
    {
        // Handle sign-in button click
    }

    private void SignUpButtonClicked(object sender, EventArgs e)
    {
        // Handle sign-up button click
    }
}
