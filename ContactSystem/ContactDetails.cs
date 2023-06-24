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

            //List<Address> list = new List<Address>();
            Console.WriteLine("Enter no.of details want to print:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)

            {
                AddressBook address = new AddressBook();

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
                Console.WriteLine("Edit by using First Name: ");
            }
                String name = Console.ReadLine();
                foreach (var data in list)
                {
                    AddressBook address=new AddressBook();  
                    if (data.firstname == name)
                    {
                         Console.WriteLine("Enter option to edit:\n1.First Name\n2.Second Name\n3.Address\n4.city\n5.state\n6.phone number\n7.email\n8.Exit");
                        int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        
                        {
                            case 1:
                                Console.WriteLine("Enter first name ");
                                data.firstname = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter last name ");
                                data.lastname = Console.ReadLine();
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
                                Console.WriteLine("Enter phone number");
                                data.phoneNo = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter email");
                                data.eMail = Console.ReadLine();
                                break;
                          
                            default: 
                                Console.WriteLine("Entered Invalid Option");
                                break;
                        }
                        Console.WriteLine("\n" + "FirstName   = " + data.firstname + "\n" + "Second Name = " + data.lastname + "\n" + "Address     = " + data.address + "\n"
                            + "City        = " + data.city + "\n" + "State       = " + data.state + "\n" + "PhoneNumber = " + data.phoneNo + "\n" +
                            "Zip Code    = " + data.postcode + "\n" + "Country     = " + data.country + "\n" + "Email       = " + data.eMail);

                    }
                    else
                    {
                        Console.WriteLine("Given first name is not found");
                         return;
                    }

                }
            
        }
    }
}
