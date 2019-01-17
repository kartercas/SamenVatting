using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamenVatting
{
    class Arrays
    {
        static void Main(string[] args)
        {
            //een array bevat meerdere waarden in één declaratie
            //door meteen een [] te zetten zegt ge dat ge een array aan maakt
            //in de *new* zegt ge hoeveel de array is, array begingt met 0 dus is deze 3
            int[] punten = new int[2];

            //ge zegt gewoon wat juist allemaal in de array's moet één voor één
            //pas op dit is niet de beste manier kijk naar 'Foreach Loops'
            punten[0] = 10;
            punten[1] = 12;
            punten[2] = 7;

            //de array opvragen
            //uw console uitkomst in monogame vind ge in Output
            Console.WriteLine("Punten bij de eerste index " + punten[0]);



        }
    }
}
