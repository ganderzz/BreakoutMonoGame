namespace BreakoutMonoGame.Scenes
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    class GameScene : Scene
    {
        public GameScene(GraphicsDeviceManager graphics)
        {
            var viewport = graphics.GraphicsDevice.Viewport;

            _player = new Paddle(graphics, viewport.Width / 2, viewport.Height - 50);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _player.Draw(spriteBatch);
        }

        public void Update(KeyboardState keyboard)
        {
            _player.Update(keyboard);
        }

        private Paddle _player;
    }
}
