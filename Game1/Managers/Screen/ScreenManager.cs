using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Game1.Screens;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Managers.Screen
{
    public class ScreenManager
    {
        private static ScreenManager instance;

        public Vector2 Dimensions { private set; get; }

        public ContentManager Content { private set; get; }

        private GameScreen currentScreen;
        public static ScreenManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScreenManager();
                }
                return instance;
            }
        }

        public ScreenManager()
        {
            Dimensions = new Vector2(1280,720);
            currentScreen = new SplashScreen();
        }

        public void LoadContent(ContentManager Content)
        {
            this.Content = new ContentManager(Content.ServiceProvider,"Content");
            currentScreen.LoadContent();
        }

        public void UnLoadContent()
        {
            currentScreen.UnLoadContent();
        }

        public void Update(GameTime gameTime)
        {
            currentScreen.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            currentScreen.Draw(spriteBatch);
        }
    }
}
