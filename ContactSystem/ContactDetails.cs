using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ContactSystem
{
    public class ContactDetails
    {
        List<AddressBook> list = new List<AddressBook>();

        public void details()
        {
            AddressBook address = new AddressBook();

            //List<Address> list = new List<Address>();
            Console.WriteLine("Enter no.of details want to print:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)

            {
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Information {0}" , i);

                }
                Console.WriteLine("\n");


                Console.Write("Enter firstName: ");
                address.firstname = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                address.lastname = Console.ReadLine();
                Console.Write("Enter Address: ");
                address.address = Console.ReadLine();
                Console.Write("Enter city: ");
                address.city = Console.ReadLine();
                Console.Write("Enter state: ");
                address.state = Console.ReadLine();
                Console.Write("Enter phone umber: ");
                address.phoneNo = Console.ReadLine();
                Console.Write("Enter postcode: ");
                address.postcode = Console.ReadLine();
                list.Add(address);
                Console.Write("Enter Country: ");
                address.country = Console.ReadLine();
                list.Add(address);
                Console.Write("Enter email: ");
                address.eMail = Console.ReadLine();
                list.Add(address);
                 Console.WriteLine("\n" + "FirstName   = " + address.firstname + "\n" + "Second Name = " + address.lastname + "\n" + "Address     = " + address.address + "\n"
                    + "City        = " + address.city + "\n" + "State       = " + address.state + "\n" + "PhoneNumber = " + address.phoneNo + "\n" +
                    "Zip Code    = " + address.postcode + "\n" + "Country     = " + address.country + "\n" + "Email       = " + address.eMail);
               
            }
            Console.WriteLine("Remove by using First Name: ");
            Console.WriteLine("Enter the first name");
            String name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstname == name)
                
                    address = data;
                
                list.Remove(address);
                Console.WriteLine("contact was deleted \n  " + address.firstname + "\n" + address.lastname + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNo + "\n" + address.postcode + "\n" + address.country + "\n" + address.eMail);
                Console.ReadLine();
            }

        }
        
            
        
    }
}
