using BYAJHISSAB.ViewModel;

namespace BYAJHISSAB;

public partial class Lent : ContentPage
{
	public Lent()
	{
		InitializeComponent();
        Routing.RegisterRoute("LoanType", typeof(LoanType));
        // Set the BindingContext to the ViewModel
        BindingContext = new ContactListViewModel();

    }
}