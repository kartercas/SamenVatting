using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SamenVatting 
{

    //Pakt de dingen van Game1
    class RandomColor
    {
        //Voor iets willekeurig (gebruikt 'using System')
        public static Random _rnd = new Random();
        //de rbg willekeurige waarde geven
        int r = _rnd.Next(256);
        int g = _rnd.Next(256);
        int b = _rnd.Next(256);
        //voor een costum kleur
        Color _clr = new Color();

        //fuctie met een return
        public  Color SetCol() {
            _clr = new Color(r, g, b);
            return _clr;
        }
    }
}
