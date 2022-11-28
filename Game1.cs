using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_3_Animation
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D GreyTexture,BrownTexture,CreamTexture,OrangeTexture;
        Rectangle GreyRect,BrownRect,CreamRect,OrangeRect;
        Vector2 GreySpeed,BrownSpeed,CreamSpeed,OrangeSpeed;
        SoundEffect tribbleSound;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.PreferredBackBufferWidth = 800;
            GreyRect = new Rectangle(300, 10, 100,100);
            GreySpeed = new Vector2(0,3); 
            BrownRect = new Rectangle(400, 250, 100, 100);
            BrownSpeed = new Vector2(3, 0);
            CreamRect = new Rectangle(700, 400, 100, 100);
            CreamSpeed = new Vector2(3, 3);
            OrangeRect = new Rectangle(0, 400, 100, 100);
            OrangeSpeed = new Vector2(3, 3);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            GreyTexture = Content.Load<Texture2D>("tribbleGrey");
            BrownTexture = Content.Load<Texture2D>("tribbleBrown");
            CreamTexture = Content.Load<Texture2D>("tribbleCream");
            OrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            tribbleSound = Content.Load<SoundEffect>("tribbleSound");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            GreyRect.X += (int)GreySpeed.X;
            if (GreyRect.Right > _graphics.PreferredBackBufferWidth || GreyRect.X < 0)
            {
                GreySpeed.X *= -1;
                tribbleSound.Play();
            }

            GreyRect.Y += (int)GreySpeed.Y;
            if (GreyRect.Bottom > _graphics.PreferredBackBufferHeight || GreyRect.Y < 0)
            {
                GreySpeed.Y *= -1;
                tribbleSound.Play();
            }
                
            base.Update(gameTime);

            BrownRect.X += (int)BrownSpeed.X;
            if (BrownRect.Right > _graphics.PreferredBackBufferWidth || BrownRect.X < 0)
                BrownSpeed.X *= -1;

            BrownRect.Y += (int)BrownSpeed.Y;
            if (BrownRect.Bottom > _graphics.PreferredBackBufferHeight || BrownRect.Y < 0)
            {
                BrownSpeed.Y *= -1;
                tribbleSound.Play();
            }
                
            base.Update(gameTime);

            CreamRect.X += (int)CreamSpeed.X;
            if (CreamRect.Right > _graphics.PreferredBackBufferWidth || CreamRect.X < 0)
            {
                CreamSpeed.X *= -1;
                tribbleSound.Play();
            }
               

            CreamRect.Y += (int)CreamSpeed.Y;
            if (CreamRect.Bottom > _graphics.PreferredBackBufferHeight || CreamRect.Y < 0)
            {
                CreamSpeed.Y *= -1;
                tribbleSound.Play();
            }
               
            base.Update(gameTime);


            OrangeRect.X += (int)OrangeSpeed.X;
            if (OrangeRect.Right > _graphics.PreferredBackBufferWidth || OrangeRect.X < 0)
            {
                OrangeSpeed.X *= -1;
                tribbleSound.Play();
            }
               


            OrangeRect.Y += (int)OrangeSpeed.Y;
            if (OrangeRect.Bottom > _graphics.PreferredBackBufferHeight || OrangeRect.Y < 0)
            {
                OrangeSpeed.Y *= -1;
                tribbleSound.Play();
            }
                
            base.Update(gameTime);
           




        }

        protected override void Draw(GameTime gameTime)
        {
            
            GraphicsDevice.Clear(Color.Black);
            _spriteBatch.Begin();

            _spriteBatch.Draw(GreyTexture, GreyRect, Color.White);
            _spriteBatch.Draw(BrownTexture, BrownRect, Color.White);
            _spriteBatch.Draw(CreamTexture, CreamRect, Color.White);
            _spriteBatch.Draw(OrangeTexture, OrangeRect, Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code  here

            base.Draw(gameTime);
        }
    }
}