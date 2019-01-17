using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamenVatting
{
    class TryAndCatch
    {
        //'Try and Catch' is heel goed om error op te vangen
        public void tryandcatch()
        {

            int num1 = 5;
            int num2 = 0;
            int result;
            string yeet = "Y E E T";

            //gaat proberen dit te doen
            try
            {
                result = num1 / num2;
            }
            //als de error 'DivideByZeroException' komt dan dan gebeurd het volgende
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't devide by zero!");
            }


            //kijkt of dat er er fouten zitten in de text
            try
                //zet uw code tusen de try en de eerste catch
            {
                //hier dus
                int userInputAsInt = int.Parse(yeet);
            }
            catch (FormatException)
            {
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow exception, the number was too long or too short for an int32");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways!");
            }




            Console.ReadLine();


        }


    }
}
