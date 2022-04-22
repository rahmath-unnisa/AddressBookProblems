using System;
namespace AddressBookProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Adress Book Program");
            bool end = true;
            Console.WriteLine("1. Add Contact\n2. Add Contact To Adress Book\n3. Edit A contact \n4. Delete A Contact \n5.End Program ");
            Contact contact = new Contact();
            AddressBookMain addContact = new AddressBookMain();
            while (end)
            {
                Console.WriteLine("Choose program to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Your First Name : ");
                        contact.FirstName = Console.ReadLine();

                        Console.WriteLine("Enter Your Last Name : ");
                        contact.LastName = Console.ReadLine();

                        Console.WriteLine("Enter Your Address : ");
                        contact.Address = Console.ReadLine();

                        Console.WriteLine("Enter Your City : ");
                        contact.City = Console.ReadLine();

                        Console.WriteLine("Enter Your State : ");
                        contact.State = Console.ReadLine();

                        Console.WriteLine("Enter Your Zip Code : ");
                        contact.Zip = Convert.ToInt32( Console.ReadLine());

                        Console.WriteLine("Enter Your Phone Number : ");
                        contact.PhoneNumber = (int) Convert.ToInt64( Console.ReadLine());

                        Console.WriteLine("Enter Your Email : ");
                        contact.Email = Console.ReadLine();
                        break;
                    case 2:
                        addContact.AddContactToAddressBook(contact);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Name for Edit the Information");
                        string name = Console.ReadLine();
                        addContact.EditContactInAddressBook(name);
                        break;
                    case 4:
                        addContact.DeleteTheContact();
                        break;
                    case 5:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Choose the right option");
                        break;
                }
            }

        }

    }
}
    



   