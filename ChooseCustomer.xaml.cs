namespace BYAJHISSAB;

public partial class ChooseCustomer : ContentPage
{
	public ChooseCustomer()
	{
		InitializeComponent();
        Routing.RegisterRoute("ContactList", typeof(ContactList));
        Routing.RegisterRoute("Menual", typeof(Menual));
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        if (Shell.Current != null)
        {
            await Shell.Current.GoToAsync("/ContactList");
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
            await Shell.Current.GoToAsync("/Menual");
        }
        else
        {
            Console.WriteLine("Shell.Current is null, cannot navigate.");
        }
    }
}