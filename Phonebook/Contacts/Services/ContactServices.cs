using Contacts.Model;
using System.Xml.Linq;
using Contacts.Interface;

namespace Contacts.Services
{
    public class ContactServices : IContactServices
    {
        private readonly List<Contact> _contact = new List<Contact>();
        public void AddContacts()
        {
            Contact contact = new Contact();
            do
            {
                Console.Write("Enter contact first name: ");
                string? userFirstName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userFirstName))
                {
                    contact.FirstName = userFirstName;
                    while (true)
                    {
                        Console.Write("Enter contact last name: ");
                        string? userLastName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(userLastName))
                        {
                            contact.LastName = userLastName;

                            while (true)
                            {
                                Console.Write("Enter phone number: ");
                                string? userPhonenumber = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(userPhonenumber))
                                {
                                    contact.PhoneNumber = userPhonenumber;
                                    _contact.Add(contact);
                                    Console.WriteLine("Contact added successfully");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine($"{nameof(userPhonenumber)} cannot be blank");

                                }
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"{nameof(userLastName)} cannot be blank.");

                        }

                    }
                    break;

                }

                else
                {
                    Console.WriteLine($"{nameof(userFirstName)} cannot be blank.");

                }
            } while (true);
        }
        public void ViewAllContacts()
        {
            for (int i = 0; i < _contact.Count; i++)
            {
                Contact contactlist = _contact[i];
                Console.WriteLine($"{i + 1}. {contactlist.FirstName} {contactlist.LastName}, {contactlist.PhoneNumber}");

            }
        }
        public void DeleteContact(Contact contact)
        {
            Contact? contactToDelete = _contact.FirstOrDefault(x => x.FirstName == contact.FirstName && x.LastName == contact.LastName);
            if (contactToDelete != null)
            {
                _contact.Remove(contactToDelete);
            }
            else
            {
                Console.WriteLine("Please try again, incorrect details");
            }
        }
        public Contact UpdateContact()
        {
            do
            {
                Console.Write("Enter the contact's first name: ");
                string? userInputFirstName = Console.ReadLine();

                Console.Write("Enter the contact's last name: ");
                string? userInputLastName = Console.ReadLine();

                Console.Write("Enter the contact's phone number: ");
                string? userPhoneNumber = Console.ReadLine();


                Contact? contactUpdate = _contact.FirstOrDefault(x => x.FirstName == userInputFirstName && x.LastName == userInputLastName && x.PhoneNumber == userPhoneNumber);
                if (contactUpdate == null)
                {
                    Console.WriteLine("Contact not found!");               
                    continue;
                }
                return contactUpdate;  
            } while (true);
        }

        public void SearchContactsByMatchingName()
        {
            Console.Write("Enter the name: ");
            string? userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                List<Contact> matchedContacts = _contact.Where(x => $"{x.FirstName} {x.LastName}".Contains(userInput, StringComparison.Ordinal)).ToList();
                if (matchedContacts.Count >= 0)
                {
                    foreach (var item in matchedContacts)
                    {
                        Console.WriteLine($"The phone number is {item.PhoneNumber}");
                    }
                }

                else Console.WriteLine("No contact found");
            }
        }


        public void SearchContactByPhoneNumber()
        {
            Console.Write("What is the phone number you want to search with: ");
            string? userInput = Console.ReadLine();

            Contact? contactName = _contact.FirstOrDefault(x => x.PhoneNumber == userInput);
            if (contactName != null)
            {
                Console.WriteLine($"The contact name is: {contactName.FirstName} {contactName.LastName}");
            }
            else if (contactName == null)
            {
                Console.WriteLine("Wrong phone number");
                return;
            }
        }
    }
}
