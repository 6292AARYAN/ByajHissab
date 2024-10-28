using BYAJHISSAB.ViewModel;

namespace BYAJHISSAB;

public partial class ContactList : ContentPage
{
	public ContactList()
	{
		InitializeComponent();
        Routing.RegisterRoute("LoanType", typeof(LoanType));
        // Set the BindingContext to the ViewModel
        BindingContext = new ContactListViewModel();
        
    }

    private async void OnItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item == null)
            return;

        // Get the selected contact
        var selectedContact = (Customer)e.Item;

        // Navigate to the new page, passing the selected contact details
        await Shell.Current.GoToAsync("/LoanType");

        // Deselect the item
        ((ListView)sender).SelectedItem = null;
    }



}
