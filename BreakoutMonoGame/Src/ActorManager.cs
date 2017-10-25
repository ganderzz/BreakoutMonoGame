namespace BreakoutMonoGame.Src
{
    using BreakoutMonoGame.Src.GameObjects;
    using System.Collections.Generic;
    using Microsoft.Xna.Framework.Input;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework.Content;

    public class ActorManager
    {
        public void Add(GameObject gameObject)
        {
            _objects.Add(gameObject.GetHashCode().ToString(), gameObject);
        }

        public void UpdateAll(KeyboardState keyboard)
        {
            foreach(var obj in _objects)
            {
                obj.Value.Update(keyboard);
            }
        }

        public void DrawAll(SpriteBatch spriteBatch)
        {
            foreach (var obj in _objects)
            {
                obj.Value.Draw(spriteBatch);
            }
        }

        public void LoadAllContent(ContentManager content)
        {
            foreach (var obj in _objects)
            {
                obj.Value.LoadContent(content);
            } 
        }

        Dictionary<string, GameObject> _objects = new Dictionary<string, GameObject>();
    }
}
