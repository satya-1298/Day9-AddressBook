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
        List<AddressBook> list = new List<AddressBook>();
       
        public void Details()
        {
            AddressBook address = new AddressBook();
           Console.Write("Enter firstName: ");
            address.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            address.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            address.address = Console.ReadLine();
            Console.Write("Enter city: ");
            address.city = Console.ReadLine();
            Console.Write("Enter state: ");
            address.state = Console.ReadLine();
            Console.Write("Enter Zip");
            address.postcode = Console.ReadLine();  
            Console.Write("Enter country");
            address.country = Console.ReadLine();
            Console.Write("Enter phone umber: ");
            address.phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            address.eMail = Console.ReadLine();
            list.Add(address);
            Console.WriteLine("\n");
        }
        public void displayContact()
        {
            foreach (var address in list)
            {
                
                Console.WriteLine(address.firstName + "\n" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.eMail+"\n");
            }
        }
        public void editContact()
        {
            Console.WriteLine("Edit by using First Name: ");
            String name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstName == name)
                {
                    Console.WriteLine("Enter option to edit:\n1.First Name\n2.Second Name\n3.Address\n4.city\n5.state\n6.phone number\n7.email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter first name ");
                            data.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter last number ");
                            data.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter address");
                            data.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter city");
                            data.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter state");
                            data.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter phne number");
                            data.phoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter email");
                            data.eMail = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void deleteContact()
        {
            AddressBook address = new AddressBook();
            Console.WriteLine("Enter name to delete details");
            String name = Console.ReadLine();
            foreach (var data in list)
            {
                if (data.firstName.Equals(name))
                    address = data;
            }
            list.Remove(address);
        }
    }
}
