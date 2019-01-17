using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace SamenVatting
{
    /*
     * Dit is een samenvatting van de PD1
     * idv een werkend spel te hebben zit dit programma vol met snippets van code
     * Deze code bevatten uitleg over vershillende thema's en voorbeelden van "speciale" code
     * er is geen spellings corrector in VS dus verwacht typo's
     */
    public class Game1 : Game 
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        //Inisializeerd de class RandomColor
        RandomColor randomColor = new RandomColor();
        //Inisializeerd de class ForeashLoops
        ForeashLoops foreashLoop = new ForeashLoops();
        //Inisializeerd de class ClassBasic
        //hier kan je je variable in geven
        ClassBasic yeboi = new ClassBasic("Caspert", "V.O.");


        Color _randomColor;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            //Verander de resulutie
            graphics.PreferredBackBufferHeight = GameConstant.Game1WindowHeight;
            graphics.PreferredBackBufferWidth = GameConstant.Game1WindowWidth;
            //zorgt er voor dat de muis zicht baar word
            IsMouseVisible = true;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here


            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            //maakt een willekeurige kleur aan
            _randomColor = randomColor.SetCol();
            //Console.WriteLine kan worden gebruikt om dingen makkelijk te debuggen
            Console.WriteLine(_randomColor);
            //Alles in de Initialize word maar één keer uitgevoerd in het begin

            //foreashLoop();

            //doet de method van ClassBasic
            yeboi.Ik();

            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);



            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
