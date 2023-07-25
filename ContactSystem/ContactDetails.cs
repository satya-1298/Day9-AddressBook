using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ContactSystem
{
    public class ContactDetails
    {
        Dictionary<string, List<AddressBook>> addressList = new Dictionary<string, List<AddressBook>>();
        List<AddressBook> list = new List<AddressBook>();
        public void AddAddress()
        {
            AddressBook address = new AddressBook();
            Console.Write("Enter firstName : ");
            address.firstName = Console.ReadLine();
            string name = "^[A-Z]{1}[a-zA-z]{3,}$";

            if (addressList.ContainsKey(address.firstName))
            {
                Console.WriteLine("Duplicate entries are not possible");
            }
            else
            {

                Console.Write("Enter Last Name : ");
                address.lastName = Console.ReadLine();
                string reg = "^[A-Z]{1}[a-zA-z]{3,}$";
                if (Regex.IsMatch(address.lastName, reg))
                {

                    Console.Write("Enter Address : ");
                    address.address = Console.ReadLine();
                    string var = "[A-Za-z]{6,}";
                    if (Regex.IsMatch(address.address, var))
                    {

                        Console.Write("Enter city : ");
                        address.city = Console.ReadLine();
                        if (Regex.IsMatch(address.city, reg))
                        {
                            Console.Write("Enter state : ");
                            address.state = Console.ReadLine();
                            if (Regex.IsMatch(address.state, reg))
                            {
                                Console.Write("Enter Zip : ");
                                address.postcode = Console.ReadLine();
                                string zip = "^[1-9]{1}[0-9]{4,}";
                                if (Regex.IsMatch(address.postcode, zip))
                                {
                                    Console.Write("Enter country : ");
                                    address.country = Console.ReadLine();
                                    if (Regex.IsMatch(address.country, reg))
                                    {
                                        Console.Write("Enter phone number : ");
                                        address.phoneNumber = Console.ReadLine();
                                        string number = "[7-9]{1}[0-9]{9}";
                                        if (Regex.IsMatch(address.phoneNumber, number))
                                        {
                                            Console.Write("Enter email : ");
                                            address.eMail = Console.ReadLine();
                                            string pattern = "^[0-9A-Za-z]+[.+_-]{0,1}[0-9A-Za-z]+[@][A-Za-z]+[.][a-z]{2,3}([.][a-z]{2,3}){0,1}$";
                                            if(Regex.IsMatch(address.eMail, pattern))
                                            {
                                                Console.WriteLine("DETAILS FILLED SUCCESSFULLY");
                                            }
                                            else
                                            {
                                                Console.WriteLine("InValid");
                                            }

                                        }
                                    }

                                }
                            }
                        }
                    }
                }              
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
                Console.WriteLine(key + " Details are");
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
            Console.WriteLine("The people in {0} state are: ", state);
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
        public void CountAddress()
        {
            int count = 0;
            Console.WriteLine("Enter city to search");
            string state = Console.ReadLine();
            Console.WriteLine("The people in {0} state are: ", state);
            foreach (var key in addressList.Keys)
            {
                foreach (var items in addressList[key].Where(x => x.state.Equals(state)).ToList())
                {
                    Console.WriteLine("\n" + "FirstName   = " + items.firstName + "\n" + "Second Name = " + items.lastName + "\n" + "Address     = " + items.address + "\n"
                                                     + "City        = " + items.city + "\n" + "State       = " + items.state + "\n" + "PhoneNumber = " + items.phoneNumber + "\n" +
                                                     "Zip Code    = " + items.postcode + "\n" + "Country     = " + items.country + "\n" + "Email       = " + items.eMail);
                    count++;
                }
            }
            Console.WriteLine("There are {0} Persons in {1} state", count, state);
        }
        public void Read_File()
        {
            int count = 0;
            string path = @"C:\Users\PC\Desktop\RFP288-Assignment\Day9-AddressBook\ContactSystem\File\Address.txt";
            count++;
            var dataToWrite = from values in list select ("Address of "+values.firstName+"\n"+" FirstName = " + values.firstName + " \n " + "LastName = " + values.lastName + " \n " + "PhoneNumber = " + values.phoneNumber + " \n " + "State = " + values.state + " \n " + "Country = " + values.country+" \n "+"Zip Code = "+ values.postcode+" \n "+"Email = "+values.eMail+"\n");

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var dataLine in dataToWrite)
                {
                    sw.WriteLine(dataLine);


                }
            }

        }
    }
}

