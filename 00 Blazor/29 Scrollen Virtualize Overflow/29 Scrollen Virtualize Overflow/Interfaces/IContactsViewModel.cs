using _29_Scrollen_Virtualize_Overflow.Data;

namespace _29_Scrollen_Virtualize_Overflow.Interfaces
{
    public interface IContactsViewModel
    {
        public interface IContactsViewModel
        {
            public IEnumerable<Contact> Contacts { get; }
            public int ContactsCount { get; }

            //Next two methods are gonna load the actual contacts
            public Task LoadContactsCountDB();
            public Task LoadAllContactsDB();
            public Task LoadOnlyVisibleContactsDB(int startIndex, int numberOfUsers);

        }
    }
}
