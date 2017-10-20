namespace BreakoutMonoGame
{
    using Microsoft.Xna.Framework;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;

    class Paddle
    {
        public Paddle(GraphicsDeviceManager graphics, float x, float y)
        {
            _playerTexture = new Texture2D(graphics.GraphicsDevice, _width, _height);
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
            Color[] data = new Color[_width * _height];

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Color.White;
            }

            _playerTexture.SetData(data);

            spriteBatch.Draw(_playerTexture, _position, Color.White);
        }

        private Texture2D _playerTexture;
        private Vector2 _position;
        private float _velocityX = 9;

        private int _width = 90;
        private int _height = 20;
    }
}
