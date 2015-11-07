using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Screens
{
    public class SplashScreen : GameScreen
    {
        private Texture2D image;
        private string path;
        public override void LoadContent()
        {
            base.LoadContent();
            path ="images/splash";
            image = content.Load<Texture2D>(path);
        }

        public override void UnLoadContent()
        {
            base.UnLoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image,Vector2.Zero,Color.White);
        }
    }
}
