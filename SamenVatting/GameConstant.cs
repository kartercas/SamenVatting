using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamenVatting
{
    //Hier word variablen in gestoken die constant zijn
    //dere worden gebruikt in verschillende classen en scripts
    //De eerste woord is waar de classe in zit
    class GameConstant
    {
        //scherm resulutie
        public const int Game1WindowHeight = 720;
        public const int Game1WindowWidth = 1280;

        //Player
        public static float PLAYERACCELERATIONY = 0.14f;
        public static float PLAYERACCELERATIONMINY = 3f;
        public static int PLAYERANIMATIONCOUNTER = 2;
        public static int PLAYERGROUND = 698;
        public static int PLAYERDIFFIDEDSMALLER = 4;
        public static int ANIMATIONTIMEINMILLISECONDS = 150;

    }
}
