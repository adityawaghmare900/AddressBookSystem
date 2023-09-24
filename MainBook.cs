namespace EditExistingContact_UC3
{
    internal class MainBook
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            addressBook.AddBook();
            Console.WriteLine("=================================================");
            addressBook.display();
            Console.WriteLine("=================================================");
            addressBook.Edit();
            Console.WriteLine("=================================================");
           // addressBook.display();
            
        }
    }
}