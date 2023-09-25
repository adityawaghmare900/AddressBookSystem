using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipleAddressBook_UC6
{
    public class AddressBook
    {
        List<Contact> contactList= new List<Contact>();
        Dictionary<string, AddressBook> dict = new Dictionary<string, AddressBook>();

        public void addContact()
        {
                Contact contact = new Contact();
                Console.Write("Enter the first name: ");
                contact.FirstName = Console.ReadLine();

                Console.Write("Enter the last name: ");
                contact.LastName = Console.ReadLine();

                Console.Write("Enter the Address: ");
                contact.Address = Console.ReadLine();

                Console.Write("Enter the city name: ");
                contact.City = Console.ReadLine();

                Console.Write("Enter the State name: ");
                contact.state = Console.ReadLine();

                Console.Write("Enter the ZipCode name: ");
                contact.zipcode = long.Parse(Console.ReadLine());

                Console.Write("Enter the Phone Number: ");
                contact.Phone = long.Parse(Console.ReadLine());

                Console.Write("Enter the Email Id: ");
                contact.emailID = Console.ReadLine();

                contactList.Add(contact);
            
        }


        public void addMultiple()
        {
            while (true)
            {
                Console.WriteLine("Address Book System");
                Console.WriteLine("1. create Address Book\n 2. add contact information in address book\n " +
                    "3. Display Address Book and contact");
                int choice=Convert.ToInt16(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Enter the unique name for Address Book");
                        string book= Console.ReadLine();
                        if (!dict.ContainsKey(book))
                        {
                           dict[book]=new AddressBook();
                            Console.WriteLine("Address Book '{book} created");
                        }
                        else
                        {
                            Console.WriteLine("Address Book with name {book} is already exist");
                        }
                    break;

                    case 2:
                        Console.WriteLine("Enter Address Book name");
                        string bookName= Console.ReadLine();
                        if (dict.ContainsKey(bookName))
                        {
                            
                            dict[bookName].addContact();
                            Console.WriteLine("Contact added in {bookName} successfuly");

                        }
                        else
                        {
                            Console.WriteLine("{bookName} does not exit");
                        }
                        Console.WriteLine("=====================================================");

                        break;

                    case 3:
                        Console.WriteLine("Address book and Contacts");
                        foreach(var pair in dict)
                        {
                            Console.WriteLine("Address Book: "+pair.Key);
                            Console.WriteLine("Contacts:");
                            foreach(var contact in pair.Value.contactList)
                            {
                                Console.WriteLine("First Name: " + contact.FirstName);
                                Console.WriteLine("Last Name: " + contact.LastName);
                                Console.WriteLine("Address: " + contact.Address);
                                Console.WriteLine("City: " + contact.City);
                                Console.WriteLine("State: " + contact.state);
                                Console.WriteLine("ZipCode: " + contact.zipcode);
                                Console.WriteLine("Phone: " + contact.Phone);
                                Console.WriteLine("Email Id: " + contact.emailID);
                                Console.WriteLine("=====================================================");
                            }
                        }
                        break;
                        Console.WriteLine("=====================================================");


                    case 4:
                        Console.WriteLine("Exiting the program.");
                        return;
                        Console.WriteLine("=====================================================");


                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                        Console.WriteLine("=====================================================");

                }
            }
        }

    }
}
