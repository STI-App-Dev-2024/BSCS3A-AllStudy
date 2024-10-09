namespace AllStudy
{


    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            await Task.Delay(4000);

            ShowLoading(true);

            await Task.Delay(4000);
            
            ShowLoading(false);

            Application.Current.MainPage = new SignInPage();
        }

            
        private void ShowLoading(bool isLoading)
        {
            LoadingOverlay.IsVisible = isLoading;
            
            
        }
    }
}


