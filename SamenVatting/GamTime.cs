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
    class GamTime
    {
        Boolean create;
        public void Update(GameTime gameTime)
        {
          //gameTime kunt ge alleen in update & draw functie toepassen
          if (gameTime.TotalGameTime.Milliseconds % 100 == 0)
          {
          create = true;
          }
        }      
    }
}
