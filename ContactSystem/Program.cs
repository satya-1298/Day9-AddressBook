using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactSystem
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            ContactDetails add = new ContactDetails();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Choose the option");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1.Add Contact\n2.Display\n3.SearchContactByState\n4.CountPersonInSameState\n5.Write Contact to File\nEnter your option: ");
                Console.WriteLine("---------------------------------------------");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.AddAddress();
                        break;
                    case 2:
                        add.Display();
                        break;
                    case 3:
                        add.SearchByState();
                        break;
                    case 4:
                        add.CountAddress();
                        break;
                    case 5:
                        add.Read_File();
                        break;
                    default :
                        flag = false;
                        break;
                }
            }
        }
    }
}
