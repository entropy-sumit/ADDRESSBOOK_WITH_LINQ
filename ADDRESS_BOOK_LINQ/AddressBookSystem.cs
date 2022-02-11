using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESS_BOOK_LINQ
{
    class AddressBookSystem
    {
        DataTable table = new DataTable("AddressBookSystem"); // UC 1 Create a new DataTable

        public AddressBookSystem()
        {
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(string));
            table.Columns.Add("PhoneNumber", typeof(string));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add("sumit", "rawat", "surajkund", "gorakhpur", "uttar pradesh", "273015", "91411919", "sumitraw@gmail.com");
            table.Rows.Add("sweta", "singh", "shahi colony", "Patana", "bihar", "44121", "9333934858", "sweta@gmail.com");
            table.Rows.Add("Vinay", "kumar", "naini", "allahabad", "uttar pradesh", "672206", "9894561230", "vinay@gmail.com.a");


        }
        public void GetAllContacts()
        {
            try
            {
                Console.WriteLine("\n");
                foreach (DataRow dr in table.AsEnumerable())
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("FirstName:- " + dr.Field<string>("firstName"));
                    Console.WriteLine("LastName:- " + dr.Field<string>("lastName"));
                    Console.WriteLine("Address:- " + dr.Field<string>("address"));
                    Console.WriteLine("City:- " + dr.Field<string>("city"));
                    Console.WriteLine("State:- " + dr.Field<string>("state"));
                    Console.WriteLine("Zip:- " + dr.Field<string>("zip"));
                    Console.WriteLine("PhoneNumber:- " + dr.Field<string>("phoneNumber"));
                    Console.WriteLine("Email:- " + dr.Field<string>("eMail"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.HelpLink);
            }

        }
       
        public void EditExistingContact(string firstName, string lastName, string column, string newValue)
        {
            DataRow contact = table.Select("FirstName = '" + firstName + "' and LastName = '" + lastName + "'").FirstOrDefault();
            contact[column] = newValue;
            Console.WriteLine("Record successfully Edit");
            GetAllContacts();

        }
    }
}