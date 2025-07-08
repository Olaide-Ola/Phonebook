using Contacts.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts.Interface
{
    internal interface IContactServices
    {
        void AddContacts();
        void ViewAllContacts();
        void SearchContactByPhoneNumber();
        void SearchContactsByMacthingName();
        void DeleteContact(Contact contact);
        Contact UpdateContact();
    }
}
