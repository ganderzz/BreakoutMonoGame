namespace BreakoutMonoGame.Src.GameObjects
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class Ball : GameObject
    {
        public Ball(GraphicsDeviceManager graphics, float x, float y)
        {
            _pos = new Vector2(x, y);
        }

        public void LoadContent(ContentManager content)
        {
            _texture = content.Load<Texture2D>("bin\\DesktopGL\\ball");
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _pos, origin: new Vector2(0, 0));
        }

        public void Update(KeyboardState keyboard)
        {
            return;
        }

        Texture2D _texture;
        Vector2 _pos;
    }
}
