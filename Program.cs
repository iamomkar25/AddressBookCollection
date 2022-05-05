using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_UsingCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome To Address Book System!");
            AddrBook.GetCustomer();
            AddressBook_UsingCollection.AddrBook.Modify();
            AddrBook.ListingPeople();

        }
    }
}
