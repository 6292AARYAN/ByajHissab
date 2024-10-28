
using BYAJHISSAB.ViewModel;
using Microsoft.Maui.Controls;
using System;

namespace BYAJHISSAB;

public partial class Borrowed : ContentPage
{
	public Borrowed()
	{
		InitializeComponent();
        Routing.RegisterRoute("LoanType", typeof(LoanType));
        // Set the BindingContext to the ViewModel
        BindingContext = new ContactListViewModel();
    }

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Signup());
    }
}