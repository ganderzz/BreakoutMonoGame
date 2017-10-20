namespace BreakoutMonoGame
{
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public interface Scene
    {
        void Update(KeyboardState keyboard);
        void Draw(SpriteBatch spriteBatch);
    }
}
