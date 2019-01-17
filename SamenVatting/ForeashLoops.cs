using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamenVatting
{
    class ForeashLoops
    {
        public ForeashLoops()
        {
            //een array maken met 10 getallen
            int[] nums = new int[10];

            //ééntje bijvoegen voor elke index
            //dus index 0 = 0, index 1 = 1, index 4 = 4, ezv
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i;
            }

            //schrijft heel de index
            //
            //welke letter dat je gebruikt maakt niet uit, het hoe dat je het gebruikt ;)
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine("Element " + j + " = " + nums[j]);
            }

            int counter = 0;
            foreach(int i in nums)
            {
                Console.WriteLine("Element " + counter + " = " + i);
                //doet er ééntje bij elke keer
                counter++;
            }
            Console.ReadLine();

            //for & foreach kunnen vaak het zelfde doen, het is dan aan jou(of docent) om te zien wat het beste is.

            //maakt een array met de namen van 5 mensen
            string[] mensen = { "Jan", "Ton", "Benjamin", "Bert", "Mishel" };
            //ze worden elk gegroet door mij :)
            foreach (string naam in mensen)
            {
                Console.WriteLine("Hallo, " + naam + " jij bent mijn vriend :)");
            }
            Console.ReadLine();
        }
    }
}
