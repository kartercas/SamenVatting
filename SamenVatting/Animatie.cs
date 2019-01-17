using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace SamenVatting 
{
    //en nog wat andere shit
    //basicly heel mij character

    class Animatie : GameConstant
    {

        #region declaraties
        private Vector2 _pos;
        public Vector2 Position
        {
            get { return _pos; }
            set { _pos = value; }
        }
        Vector2 _originalPos;
        Texture2D _currentSprite;
        //we maken de texture een array omdat er meerdere sprite's in zitten
        public Texture2D[] _spriteWalk;

        bool _vorigJumpKey = false;
        public bool IsAlive { get; set; }

        public Rectangle _drawRectangle;
        //kijken waar de personage is voor hitditecie
        public Rectangle _playerrect;


        public Rectangle DrawRectangle
        {
            get { return _drawRectangle; }
            set { _drawRectangle = value; }
        }

        int _animateller;
        public int Animatieteller
        {
            get { return _animateller; }
            set { _animateller = value; }
        }

        private Vector2 _acceleration;
        public Vector2 Acceleration
        {
            get { return _acceleration; }
            set { _acceleration = value; }
        }

        private Vector2 _velocity;
        public Vector2 Velocity
        {
            get { return _velocity; }
            set { _velocity = value; }
        }

        public static int _life = 100;
        #endregion

        public Animatie(Vector2 position, Texture2D[] spriteWalk)
        {
            //de positie en 
            _pos = position;
            //de positie waar het origineel stond
            _originalPos = _pos;
            //de wandel animatie
            _spriteWalk = spriteWalk;
            _currentSprite = _spriteWalk[Animatieteller];
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //kijken of dat ie leeft
            if (IsAlive == true)
            {
                //tekent de juiste sprite 
                spriteBatch.Draw(_spriteWalk[Animatieteller], _drawRectangle, Color.White);
            }
        }

        public void Update(GameTime gameTime)
        {
            //De positie van de het personage
            _playerrect = new Rectangle((int)_pos.X, (int)_pos.Y, _currentSprite.Width / PLAYERDIFFIDEDSMALLER, _currentSprite.Height / PLAYERDIFFIDEDSMALLER);

            if (gameTime.TotalGameTime.Milliseconds % ANIMATIONTIMEINMILLISECONDS == 0)
            {
                Console.Write(_currentSprite.Width);
                //van animatie varanderen
                Animatieteller++;
                //de animatie teller reseten
                if (Animatieteller == PLAYERANIMATIONCOUNTER)
                {
                    Animatieteller = 0;
                }
            }
        }



    }
}

