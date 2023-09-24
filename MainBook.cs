namespace Add_New_Contact_UC2
{
    internal class MainBook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome To Address Book");
            Console.WriteLine();

            AddressBook addressBook = new AddressBook();
            addressBook.AddBook();
            addressBook.display();
        }
    }
}