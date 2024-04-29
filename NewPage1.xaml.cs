namespace noureddinebenseddik;

public partial class NewPage1 : ContentPage
{
    public NewPage1(int correctPasswordCount)
    {
        InitializeComponent();
        CountLabel.Text = "Password entered correctly " + correctPasswordCount + " time(s).";
    }
    private async void GoBackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync(); // Navigates back to the previous page (MainPage)
    }
}
