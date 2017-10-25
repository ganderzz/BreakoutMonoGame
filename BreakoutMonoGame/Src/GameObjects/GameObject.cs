namespace BreakoutMonoGame.Src.GameObjects
{
    using Microsoft.Xna.Framework.Content;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public interface GameObject
    {
        void Update(KeyboardState keyboard);
        void Draw(SpriteBatch spriteBatch);
        void LoadContent(ContentManager content);
    }
}
