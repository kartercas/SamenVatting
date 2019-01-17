using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamenVatting
{
    class SwitchStatement
    {
        public void switchstatement()
        {

            int age = 19;
            //kijkt naar leeft tijd en ziet tussen welke het is
            //is eigenlijk gewoon if's maar dan beter
            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            //Code maar dan in if's
            if (age == 15)
            {
                Console.WriteLine("Too young to party in the club!");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you then?");
            }


            //Ander voorbeeld
            string username = "Frank";

            switch (username)
            {
                case "Denis":
                    Console.WriteLine("username is Denis");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }



            Console.Read();

        }
    }
}
