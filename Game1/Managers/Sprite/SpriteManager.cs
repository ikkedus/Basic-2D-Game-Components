using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Game1.Managers.Sprite
{
    public class SpriteManager
    {
        private float _transitionTime;

        public int Index { get; set; }

        public int[] Sequence { get; set; }

        public int TileX { get; set; }

        public int TileY { get; set; }

        public int Time { get; set; }

        public bool Looping { get; set; }

        public Texture2D Texture { get; set; }

        public Vector2 Position { get; set; }
        public Point TileSize => GetMaxFrames(Texture.Width, Texture.Height);


        public void Update(GameTime gameTime)
        {
            _transitionTime = (float) gameTime.ElapsedGameTime.TotalMilliseconds;

            if (_transitionTime > Time)
            {
                _transitionTime = 0;
                Index++;
              
                if (Index > Sequence.Length)
                {
                    if (Looping)
                    {
                        Index = 0;
                    }
                    else
                    {
                        Index = Sequence.Length - 1;
                    }
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch,Color color)
        {
            if (Index > Sequence.Length - 1)
            {
                Index = Sequence.Length - 1;
            }
            var xSequence = Sequence[Index] % TileX;
            var ySequence = Sequence[Index] / TileX;

            var rect = new Rectangle(
                xSequence * TileSize.X, ySequence * TileSize.Y,
                TileSize.X,TileSize.Y
                );

            spriteBatch.Draw(Texture, Position,rect,color);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            Draw(spriteBatch,Color.White);
        }

        private Point GetMaxFrames(int width, int height)
        {
            return new Point(width/ TileX,height/TileY);
        }

        public static int[] Inject(params int[] sequance)
        {
            return sequance;
        }

    }
}
