namespace BreakoutMonoGame
{
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Input;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework.Content;

    public class SceneManager
    {
        private SceneManager() { }

        public static SceneManager Instance {
            get {
                if (_instance == null)
                {
                    _instance = new SceneManager();
                }

                return _instance;
            }
        }

        public void Add(Scene scene)
        {
            _scenes.Add(scene);
        }

        public void LoadContent(ContentManager content)
        {
            _scenes[0]?.LoadContent(content);
        }

        public void Update(KeyboardState keyboard)
        {
            _scenes[0]?.Update(keyboard);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _scenes[0]?.Draw(spriteBatch);
        }

        private static SceneManager _instance;
        private List<Scene> _scenes = new List<Scene>();
    }
}
