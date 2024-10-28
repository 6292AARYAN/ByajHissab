using System.Collections.ObjectModel;

namespace BYAJHISSAB.ViewModel
{

    public class ContactListViewModel
    {

        //ObservableCollection ensures changes in the collection are reflected in the UI
        public ObservableCollection<Customer> Contacts { get; set; }

        public ContactListViewModel()
        {
            // Initialize the Contacts list with some sample data
            Contacts = new ObservableCollection<Customer>
            {
                new Customer { Name = "John Doe", PhoneNumber = "1234567890" },
                new Customer { Name = "Jane Smith", PhoneNumber = "0987654321" },
                new Customer { Name = "John Doe1", PhoneNumber = "1234567890" },
                new Customer { Name = "Jane Smith1", PhoneNumber = "0987654321" },
                 new Customer { Name = "Aaryan", PhoneNumber = "1234567890" },
                new Customer { Name = "Pankaj", PhoneNumber = "0987654321" }
                
                // Add more contacts as needed
            };
        }

    }
}
