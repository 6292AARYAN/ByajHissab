namespace BYAJHISSAB;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using System;

public partial class MainPopup : Popup
{
    public INavigation NavigationContext { get; set; }

    public MainPopup()
    {
        InitializeComponent();
        ClosePopupCommand = new Command(ClosePopup);
        BindingContext = this;
        Routing.RegisterRoute("ChooseCustomer", typeof(ChooseCustomer));
    }

    public Command ClosePopupCommand 
    { 
        get; 
    }

    private async void ClosePopup()
    { 
        Close();
    }

    private async void OnPopupOpened(object sender, PopupOpenedEventArgs e)
    {
        // Set initial scale and opacity for the animation
       
        
    }

    private async void OnPopupClosed(object sender, PopupClosedEventArgs e)
    {
        // Add any additional behavior when popup is closed
        await Task.CompletedTask;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (Shell.Current != null)
        {
            await Shell.Current.GoToAsync("/ChooseCustomer");
        }
        else
        {
            Console.WriteLine("Shell.Current is null, cannot navigate.");
        }
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        if (Shell.Current != null)
        {
            await Shell.Current.GoToAsync("/ChooseCustomer");
        }
        else
        {
            Console.WriteLine("Shell.Current is null, cannot navigate.");
        }

    }
}