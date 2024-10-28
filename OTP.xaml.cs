namespace BYAJHISSAB;

public partial class OTP : ContentPage
{
	public OTP()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        // Navigate to Forgot Password Page
        Navigation.PushAsync(new Signup());
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new LoginPassword());
    }
}