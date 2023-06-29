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
                Console.Write("1.Add Contact\n2.Display\n3.Edit\n4.delete\n5.exit\nEnter your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        add.Details();
                        break;
                    case 2:
                        add.displayContact();
                        break;
                    case 3:
                        add.editContact();
                        break;
                    case 4:
                        add.deleteContact();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
