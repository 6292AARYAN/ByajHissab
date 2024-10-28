using Microsoft.Maui.Controls;
using System;
using CommunityToolkit.Maui.Views;

namespace BYAJHISSAB;

public partial class Signup : ContentPage
{
	public Signup()
	{
		InitializeComponent();
	}
    private void OnSignupClicked(object sender, EventArgs e)
    {
        var popup = new MainPopup();
        this.ShowPopup(popup);
        // Navigate to HomePage after successful login
        //Navigation.PushModalAsync(new MainPage());
        
    }
}