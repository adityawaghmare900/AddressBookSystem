namespace AddMultiplePersong_UC5
{
    internal class MainBook
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to address book!");

            AddressBook addressBook = new AddressBook();
           // addressBook.AddBook();
           // Console.WriteLine("=================================================");
           // addressBook.display();
          //  Console.WriteLine("=================================================");
            // addressBook.Edit();
          //  Console.WriteLine("=================================================");
            // addressBook.display();

           // Console.WriteLine("==================================================");
           // addressBook.Delete();
           // Console.WriteLine("==================================================");
           // addressBook.display();
           /// Console.WriteLine("==================================================");
            addressBook.AddMultiple();
            addressBook.display();

        }
    }
    
}