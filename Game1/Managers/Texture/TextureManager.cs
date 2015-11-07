using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Managers.Texture
{
    public class TextureManager
    {
        public enum TextureID
        {
            Empty,

        }

        public enum TextureType
        {
            Menu,
        }
        private static bool initialized = false;

        private static List<TextureEntity> textureEntities = new List<TextureEntity>();

        public static void Initialize(ContentManager content)
        {
            if (initialized)
            {
                return;
            }



            initialized = true;
        }

        private static List<TextureEntity> LoadTextureEntities(ContentManager content ,TextureType type,params string[] filename)
        {
            var entities = new List<TextureEntity>();

            foreach (string entry in filename)
            {
                string formatted = string.Format("{0}/{1}", type.ToString(), entry);

                TextureEntity entity = new TextureEntity()
                {
                    Key = entry,
                    Texture = content.Load<Texture2D>(formatted)
                };
                entities.Add(entity);
            }
            return entities;
        }

        public static Texture2D GetTexture(TextureType type, object id)
        {
            List<TextureEntity> entities = new List<TextureEntity>();
            if (type == TextureType.Menu)
            {
                entities = textureEntities;
            }
            return entities[(int) id].Texture;
        }
    }
}
