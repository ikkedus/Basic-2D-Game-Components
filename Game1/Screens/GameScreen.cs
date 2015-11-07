using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game1.Managers.Screen;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Screens
{
    public class GameScreen
    {
        protected ContentManager content;
        public virtual void LoadContent()
        {
            content = new ContentManager(
                ScreenManager.Instance.Content.ServiceProvider,"Content");
        }

        public virtual void UnLoadContent()
        {
            content.Unload();
        }

        public virtual void Update(GameTime gameTime)
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
