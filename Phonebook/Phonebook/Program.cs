using Contacts.Services;
using Contacts.Model;
namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactServices contactServices = new ContactServices();

            Console.WriteLine("Welcome to contact menu\n" +
                "1. Add Contacts\n" +
                "2. View all Contacts\n" +
                "3. Delete Contact\n" +
                "4. Update Contact\n" +
                "5. Search for Contacts by Matching names\n" +
                "6. Search for contacts using Phone Number\n" +
                "7. Exit");

            while (true)
            {
                Console.Write("\nSelect an option: ");
                string? userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        contactServices.AddContacts();
                        break;
                    case "2":
                        contactServices.ViewAllContacts();
                        break;
                    case "3":
                        Contact contact = new Contact();

                        Console.Write("First name of the contact you want to delete? ");
                        string? contactFirstName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(contactFirstName))
                        {
                            contact.FirstName = contactFirstName;

                        }
                        Console.Write("Second name of the contact you want to delete? ");
                        string? contactSecondName = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(contactSecondName))
                        {
                            contact.LastName = contactSecondName;
                        }
                        Console.Write("What is the phone number? ");
                        string? contactPhonenumber = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(contactPhonenumber))
                        {
                            contact.PhoneNumber = contactPhonenumber;
                        }
                        contactServices.DeleteContact(contact);
                        Console.WriteLine("Contact deleted successfuly.");
                        break;

                    case "4":
                        var result = contactServices.UpdateContact();
                        if (result != null)
                        {
                            Console.WriteLine("=====================");
                            Console.Write("Enter the new first name: ");
                            string? newFirstName = Console.ReadLine();

                            if (!string.IsNullOrWhiteSpace(newFirstName))
                                result.FirstName = newFirstName;
                            else Console.WriteLine($"{nameof(newFirstName)} cannot be blank.");

                            Console.Write("Enter the new second name: ");
                            string? newSecondName = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newSecondName))
                                result.LastName = newSecondName;
                            else Console.WriteLine($"{nameof(newSecondName)} cannot be blank");

                            Console.Write("Enter new phone number: ");
                            string? newPhonenumber = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(newPhonenumber))
                                result.PhoneNumber = newPhonenumber;
                            else Console.WriteLine($"{nameof(newPhonenumber)} cannot be blank");

                            Console.WriteLine("Conttact updated successfully.");
                        }
                        break;
                    case "5":
                        contactServices.SearchContactsByMacthingName();
                        break;
                    case "6":
                        contactServices.SearchContactByPhoneNumber();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }
}
