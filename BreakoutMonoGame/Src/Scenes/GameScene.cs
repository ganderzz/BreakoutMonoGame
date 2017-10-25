namespace BreakoutMonoGame.Scenes
{
    using BreakoutMonoGame.Src.GameObjects;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    class GameScene : Scene
    {
        public GameScene(GraphicsDeviceManager graphics)
        {
            var viewport = graphics.GraphicsDevice.Viewport;

            _player = new Paddle(graphics, viewport.Width / 2, viewport.Height - 50);
            _ball = new Ball(graphics, viewport.Width / 2, viewport.Height - 100);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _player.Draw(spriteBatch);
            _ball.Draw(spriteBatch);
        }

        public void Update(KeyboardState keyboard)
        {
            _player.Update(keyboard);
            _ball.Update(keyboard);
        }

        public void LoadContent(ContentManager content)
        {
            _ball.LoadContent(content);
        }

        readonly Paddle _player;
        readonly Ball _ball;
    }
}
