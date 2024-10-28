using Microsoft.Maui.Controls;
using System;

namespace BYAJHISSAB;

public partial class LoginPassword : ContentPage
{
	public LoginPassword()
	{
		InitializeComponent();
	}

    private async void Submit_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Lent");
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        // Navigate to Forgot Password Page
        Navigation.PushAsync(new Signup());
    }
}