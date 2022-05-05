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
            Console.WriteLine("1.Enter to add the details");
            Console.WriteLine("2.Enter to modify the details");
            Console.WriteLine("3.Listing the details..");
            Console.WriteLine("4.Remove the details");
            Console.WriteLine("Enter a option");
            switch (Console.ReadLine())
            {
                case "1":
                 AddrBook.GetCustomer();
                 AddrBook.ListingPeople();
                    break;
                case "2":
                  AddrBook.GetCustomer();
                   AddrBook.Modify();
                   AddrBook.ListingPeople();
                    break;
                case "3":
                 AddrBook.GetCustomer();
                 AddrBook.ListingPeople();
                    break;
                case "4":
                AddrBook.GetCustomer();
                    AddrBook.RemovePeople();

                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;

            }

        }
    }
}
