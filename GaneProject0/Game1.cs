using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace GaneProject0
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Bidoof bidoof;
        private Phanphy phanphy;
        private Money money;
        private Krabs krabs;
        private MrKrabs mrKrabs;
        SpriteFont spriteFont;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            bidoof = new Bidoof(this, Color.White) { Position = new Vector2(0, 20) };
            phanphy = new Phanphy(this, Color.White) { Position = new Vector2(400, 100) };
            money = new Money(this, Color.White) { Position = new Vector2(100, 300) };
            krabs = new Krabs(this, Color.White) { Position = new Vector2(200, 20) };
            mrKrabs = new MrKrabs(this, Color.White) { Position = new Vector2(200, 100) };

            

            base.Initialize();
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            bidoof.LoadContent();
            phanphy.LoadContent();
            money.LoadContent();
            krabs.LoadContent();
            mrKrabs.LoadContent();

            spriteFont = Content.Load<SpriteFont>("Font");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();


            bidoof.Draw(_spriteBatch);
            phanphy.Draw(_spriteBatch);
            money.Draw(_spriteBatch);
            krabs.Draw(_spriteBatch);
            mrKrabs.Draw(_spriteBatch);
            _spriteBatch.DrawString(spriteFont, "Press Escape To Get Out Of Here!", new Vector2(300, 300), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
