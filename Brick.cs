using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AsteroidGame
{
    class Brick
    {
        /// <summary>
        ///  2 floats are used for brick position
        ///  bool Visible is used for seeing if the brick is still on the screen
        ///  Color is to allow for the brick to be able to change color for multiple instances of the brick
        /// </summary>
        public float X { get; set; } //x position of brick on screen
        public float Y { get; set; } // Brick Position
        public float Width { get; set; } //width of brick
        public float Height { get; set; } //height of brick
        public bool Visible { get; set; } // Declares if the Brick is destroyed or when it collides with our ball.
        private Color color;
        private Texture2D imgBrick { get; set; }  
        private SpriteBatch spriteBatch;  //Allows us to write on backbuffer when we need to draw the brick

        public Brick(float x, float y, Color color, SpriteBatch spriteBatch, GameContent gameContent)
        {
            X = x;
            Y = y;
            imgBrick = gameContent.BrickTexture;
            Width = imgBrick.Width;
            Height = imgBrick.Height;
            this.spriteBatch = spriteBatch;
            Visible = true;
            this.color = color;
        }
        public void Draw()
        {
            if (Visible)
            {
                spriteBatch.Draw(imgBrick, new Vector2(X, Y), null, color, 0, new Vector2(0, 0), 1.0f, SpriteEffects.None, 0);
            }
        }
    }
}
