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
       
        logoImage.Opacity = 0;
        computerImage.Opacity = 0;
        signInButton.Opacity = 0;
        signUpButton.Opacity = 0;
        greetingLabel.IsVisible = true; 
        greetingLabel.Opacity = 0;

     
        await greetingLabel.FadeTo(1, 800, Easing.CubicInOut);

        
        await Task.Delay(2000);

        await greetingLabel.FadeTo(0, 800, Easing.CubicInOut);
        greetingLabel.IsVisible = false; 

        
        await Task.WhenAll(
            logoImage.FadeTo(1, 800, Easing.CubicInOut),
            computerImage.FadeTo(1, 1000, Easing.CubicInOut),
            signInButton.FadeTo(1, 1200, Easing.CubicInOut),
            signUpButton.FadeTo(1, 1400, Easing.CubicInOut)
        );
    }

    private async void SignInButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeacherStudentlogIn());
    }

    private async void SignUpButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TeacherStudentlogIn());
    }
}
