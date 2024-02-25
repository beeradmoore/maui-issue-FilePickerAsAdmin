namespace FilePickerAsAdmin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnBrowseForFileClicked(object sender, EventArgs e)
        {
            try
            {
                var options = new PickOptions()
                {
                    PickerTitle = "Please select a file",
                };
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    await DisplayAlert("Success", "Was able to pick a file.", "Okay");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Exception: {ex.Message}", "Okay");
            }
        }
    }

}
