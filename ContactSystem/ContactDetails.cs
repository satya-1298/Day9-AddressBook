using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ContactSystem
{
    public class ContactDetails
    {
        Dictionary<string, List<AddressBook>> addressList = new Dictionary<string, List<AddressBook>>();
        public void AddAddress()
        {
            List<AddressBook> list = new List<AddressBook>();
            AddressBook address = new AddressBook();
            Console.Write("Enter firstName : ");
            address.firstName = Console.ReadLine();
            if (addressList.ContainsKey(address.firstName))
            {
                Console.WriteLine("Duplicate entries are not possible");
            }
            else
            {
               
                Console.Write("Enter Last Name : ");
                address.lastName = Console.ReadLine();
                Console.Write("Enter Address : ");
                address.address = Console.ReadLine();
                Console.Write("Enter city : ");
                address.city = Console.ReadLine();
                Console.Write("Enter state : ");
                address.state = Console.ReadLine();
                Console.Write("Enter Zip : ");
                address.postcode = Console.ReadLine();
                Console.Write("Enter country : ");
                address.country = Console.ReadLine();
                Console.Write("Enter phone umber : ");
                address.phoneNumber = Console.ReadLine();
                Console.Write("Enter email : ");
                address.eMail = Console.ReadLine();
                list.Add(address);
                addressList.Add(address.firstName, list);
            }
        }
        public void Display()
        {
            foreach (var key in addressList.Keys)
            {
                Console.WriteLine("******************************");
                Console.WriteLine("key is: " + key);
                Console.WriteLine(key +" Details are");
                foreach (var items in addressList[key])
                {
                    Console.WriteLine("\n" + "FirstName   = " + items.firstName + "\n" + "Second Name = " + items.lastName + "\n" + "Address     = " + items.address + "\n"
                                                     + "City        = " + items.city + "\n" + "State       = " + items.state + "\n" + "PhoneNumber = " + items.phoneNumber + "\n" +
                                                     "Zip Code    = " + items.postcode + "\n" + "Country     = " + items.country + "\n" + "Email       = " + items.eMail);
                }
            }
        }
        public void SearchByState()
        {
            Console.WriteLine("Enter city to search");
            string state = Console.ReadLine();
            Console.WriteLine("The people in {0} state are: " ,state);
            foreach (var key in addressList.Keys)
            {
                foreach (var items in addressList[key].Where(addressList => addressList.state.Equals(state)).ToList())
                {
                    Console.WriteLine("\n" + "FirstName   = " + items.firstName + "\n" + "Second Name = " + items.lastName + "\n" + "Address     = " + items.address + "\n"
                                                     + "City        = " + items.city + "\n" + "State       = " + items.state + "\n" + "PhoneNumber = " + items.phoneNumber + "\n" +
                                                     "Zip Code    = " + items.postcode + "\n" + "Country     = " + items.country + "\n" + "Email       = " + items.eMail);
                }
            }
        }
    }
}

