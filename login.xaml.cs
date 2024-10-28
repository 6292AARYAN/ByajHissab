using Microsoft.Maui.Controls;
using System;

namespace BYAJHISSAB;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}
    private void OnLoginClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new OTP());
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        // Navigate to Forgot Password Page
        Navigation.PushAsync(new Signup());
    }
}