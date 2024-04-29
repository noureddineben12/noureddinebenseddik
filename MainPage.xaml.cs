namespace noureddinebenseddik
{
    public partial class MainPage : ContentPage
    {
        private int correctPasswordCount = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SubmitButton_Clicked(object sender, EventArgs e)
        {
            string password = passwordEntry.Text;
            if (password == "DAM2024")
            {
                correctPasswordCount++;
                Navigation.PushAsync(new NewPage1(correctPasswordCount));
            }
            else
            {
                DisplayAlert("Incorrect Password", "Please try again.", "OK");
            }
        }
    }

}
