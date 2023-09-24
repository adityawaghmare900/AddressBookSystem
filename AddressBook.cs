using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_New_Contact_UC2
{
    public class AddressBook
    {
        List<Contact> add=new List<Contact>();
        public void AddBook()
        {
            Contact contact= new Contact();
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
            contact.Phone =long.Parse(Console.ReadLine());

            Console.Write("Enter the Email Id: ");
            contact.emailID = Console.ReadLine();

            add.Add(contact);
        }

        public void display()
        {
            Console.WriteLine("=====================================================");
            foreach(Contact contact in add)
            {
                Console.WriteLine("First Name: " + contact.FirstName);
                Console.WriteLine("Last Name: " + contact.LastName);
                Console.WriteLine("Address: " + contact.Address);
                Console.WriteLine("City: " + contact.City);
                Console.WriteLine("State: " + contact.state);
                Console.WriteLine("ZipCode: " + contact.zipcode);
                Console.WriteLine("Phone: " + contact.Phone);
                Console.WriteLine("Email Id: " + contact.emailID);
            }
        }
    }
}
