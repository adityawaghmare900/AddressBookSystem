using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeletePerson_UC4
{
    internal class AddressBook
    {
        List<Contact> add = new List<Contact>();
        public void AddBook()
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

            add.Add(contact);
        }

        public void display()
        {
            Console.WriteLine("=====================================================");
            foreach (Contact contact in add)
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

        public void Edit()
        {
            Console.WriteLine("Enter the First name");
            string data = Console.ReadLine();
            foreach (var contact in add)
            {
                if (contact.FirstName.Equals(data))
                {
                    Console.WriteLine("enter your choice to change: 1.First Name\n 2.Last Name\n 3.Address\n 4.City\n 5.State\n 6.zipcode\n 7.phone\n 8.emailId\n");
                    int choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the new name:");
                            string name = Console.ReadLine();
                            contact.FirstName = name;
                            Console.WriteLine("first name added successfully");
                            break;

                        case 2:
                            Console.Write("Enter the new last:");
                            string last = Console.ReadLine();
                            contact.LastName = last;
                            Console.WriteLine("last name added successfully");
                            break;

                        case 3:
                            Console.Write("Enter the new address:");
                            string address = Console.ReadLine();
                            contact.Address = address;
                            Console.WriteLine("new Address added successfully");
                            break;

                        case 4:
                            Console.Write("Enter the new city:");
                            string city = Console.ReadLine();
                            contact.City = city;
                            Console.WriteLine("new City added successfully");
                            break;

                        case 5:
                            Console.Write("Enter the new state:");
                            string state = Console.ReadLine();
                            contact.state = state;
                            Console.WriteLine("new state added successfully");
                            break;

                        case 6:
                            Console.Write("Enter the new zipcode:");
                            long zipcode = long.Parse(Console.ReadLine());
                            contact.zipcode = zipcode;
                            Console.WriteLine("new zipcode added successfully");
                            break;

                        case 7:
                            Console.Write("Enter the new phone number:");
                            long phone = long.Parse(Console.ReadLine());
                            contact.Phone = phone;
                            Console.WriteLine("new phone number added successfully");
                            break;

                        case 8:
                            Console.Write("Enter the new email id:");
                            string email = Console.ReadLine();
                            contact.emailID = email;
                            Console.WriteLine("new email id added successfully");
                            break;

                        case 9:
                            Console.WriteLine("invalid option");
                            break;

                    }

                }
            }
        }

        public void Delete()
        {
            Console.WriteLine("Enter the name : ");
            string name= Console.ReadLine();
            for(int i = 0; i < add.Count; i++)
            {
                if (add[i].FirstName == name)
                {
                    
                    Console.WriteLine("record {0} successfully deleted", add[i].FirstName);
                    add.RemoveAt(i);
                }
            }
        }
    }
}