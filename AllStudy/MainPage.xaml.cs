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

            ShowLoading(true);

            
            await Task.Delay(3000);

            ShowLoading(false);
        }

        
        private void ShowLoading(bool isLoading)
        {
            LoadingOverlay.IsVisible = isLoading;
        }
    }
}


