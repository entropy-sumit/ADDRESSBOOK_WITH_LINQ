using System;

namespace ADDRESS_BOOK_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the  Address Book With LINQ ");

            // UC 1 Create a new table
            AddressBookSystem addressBookTable = new AddressBookSystem();

            //addressBookTable.GetAllContacts();

            //addressBookTable.EditExistingContact("SUMIT", "RAWAT", "PhoneNumber", "876544315");

            addressBookTable.DeleteContact("sumit", "rawat");
            Console.ReadLine();
            

        }
    }
}
