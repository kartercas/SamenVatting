using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamenVatting
{
    class Arrays
    {
        static void MainArray(string[] args)
        {
            //een array bevat meerdere waarden in één declaratie
            //door meteen een [] te zetten zegt ge dat ge een array aan maakt
            //in de initialize zegt ge hoeveel de array is, array begingt met 0 dus is deze 3
            int[] punten = new int[2];

            //ge zegt gewoon wat juist allemaal in de array's moet één voor één
            //pas op dit is niet de beste manier kijk naar 'Foreach Loops'
            punten[0] = 10;
            punten[1] = 12;
            punten[2] = 7;

            //de array opvragen
            //als ge heel uw array wilt opvragen kijk dan naar 'Foreach Loop'
            //uw console uitkomst in monogame vind ge in Output
            Console.WriteLine("Punten bij de eerste index " + punten[0]);

            //een andere manier om uw array te initializeren
            int[] puntenWiskunde = { 20, 12, 6, 8 };
            //nog een andere manier
            int[] puntenVL = new int[] { 20, 17, 3, 19 };

            //vraagt de lengt van een array op
            //de Length gaan 4 zijn niet 3, omdat het telt hoeveel er zijn
            Console.WriteLine("Length van puntenWiskunde", puntenWiskunde.Length);
            //Het verschil tussen Readline en ReadKey is dat als je op een toets drukt met readkey dat hij dan pas naar de volgende gaat.
            Console.ReadKey();
        }
    }
}
