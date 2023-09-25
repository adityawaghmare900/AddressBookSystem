namespace multipleAddressBook_UC6
{
    internal class MainAddressBook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            AddressBook addressBook = new AddressBook();
            addressBook.addMultiple();
        }
    }
}