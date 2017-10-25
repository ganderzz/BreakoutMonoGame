namespace BreakoutMonoGame.Scenes
{
    using BreakoutMonoGame.Src;
    using BreakoutMonoGame.Src.GameObjects;
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    class GameScene : Scene
    {
        public GameScene(GraphicsDeviceManager graphics)
        {
            _actorManager = new ActorManager();

            var viewport = graphics.GraphicsDevice.Viewport;

            _actorManager.Add(new Paddle(graphics, viewport.Width / 2, viewport.Height - 50));
            _actorManager.Add(new Ball(graphics, viewport.Width / 2, viewport.Height - 100));
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _actorManager.DrawAll(spriteBatch);
        }

        public void Update(KeyboardState keyboard)
        {
            _actorManager.UpdateAll(keyboard);
        }

        public void LoadContent(ContentManager content)
        {
            _actorManager.LoadAllContent(content);
        }

        readonly ActorManager _actorManager;
    }
}
