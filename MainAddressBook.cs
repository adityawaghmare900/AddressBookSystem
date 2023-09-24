namespace DeletePerson_UC4
{
    internal class MainAddressBook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to address book!");

            AddressBook addressBook = new AddressBook();
            addressBook.AddBook();
            Console.WriteLine("=================================================");
            addressBook.display();
            Console.WriteLine("=================================================");
           // addressBook.Edit();
            Console.WriteLine("=================================================");
            // addressBook.display();

            Console.WriteLine("==================================================");
            addressBook.Delete();
            Console.WriteLine("==================================================");
            addressBook.display();
        }
    }
}