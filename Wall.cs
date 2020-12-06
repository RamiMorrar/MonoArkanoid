using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace AsteroidGame
{
    class Wall
    {
        public Brick[,] BrickWall { get; set; }

        public Wall(float x, float y, SpriteBatch spriteBatch, GameContent gameContent)
        {
            BrickWall = new Brick[7, 10];
            float brickX = x;
            float brickY = y;
            Color color = Color.White;
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        color = Color.Red;
                        break;
                    case 1:
                        break;
                    case 2:
                        color = Color.GhostWhite;
                        break;
                    case 3:
                        color = Color.Gold;
                        break;
                    case 4:
                        color = Color.Aqua;
                        break;
                    case 5:
                        color = Color.MonoGameOrange;
                        break;
                    case 6:
                        color = Color.Khaki;
                        break;
                }
                brickY = y + i * (gameContent.BrickTexture.Height + 1);

                for (int j = 0; j < 10; j++)
                {
                    brickX = x + j * (gameContent.BrickTexture.Width);
                    Brick brick = new Brick(brickX, brickY, color, spriteBatch, gameContent);
                    BrickWall[i, j] = brick;
                }

            }
        }
        public void Draw()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    BrickWall[i, j].Draw();
                }

            }


        }
    }
}
