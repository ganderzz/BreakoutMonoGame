namespace BreakoutMonoGame
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public interface Scene
    {
        void Update(KeyboardState keyboard);
        void Draw(SpriteBatch spriteBatch);
        void LoadContent(ContentManager content);
    }
}
