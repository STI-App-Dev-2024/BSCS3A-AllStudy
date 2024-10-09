using System.Globalization;
using Microsoft.Maui.Graphics;


namespace AllStudy;

public partial class SignInPage : ContentPage
{
    public SignInPage()
    {
        InitializeComponent();
        this.BackgroundColor = Color.FromArgb("#F0F5F9");
        
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

    }

    private void SignUpButtonClicked(object sender, EventArgs e)
    {

    }
}