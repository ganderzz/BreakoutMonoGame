namespace BreakoutMonoGame
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    public class Paddle : Src.GameObjects.GameObject
    {
        public Paddle(GraphicsDeviceManager graphics, float x, float y)
        {
            _playerTexture = new Texture2D(graphics.GraphicsDevice, _width, _height);

            Color[] data = new Color[_width * _height];

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Color.White;
            }

            _playerTexture.SetData(data);

            _position = new Vector2(x, y);
        }

        public void Update(KeyboardState keyboard)
        {
            if (keyboard.IsKeyDown(Keys.Right))
            {
                _position.X += _velocityX;
            }
            else if (keyboard.IsKeyDown(Keys.Left))
            {
                _position.X -= _velocityX;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_playerTexture, _position, Color.White);
        }

        Texture2D _playerTexture;
        Vector2 _position;
        float _velocityX = 9;

        int _width = 90;
        int _height = 20;
    }
}
