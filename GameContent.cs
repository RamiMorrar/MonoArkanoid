using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Media;
namespace AsteroidGame
{
    class GameContent
    {
        public Texture2D BrickTexture { get; set; }
        

        public Texture2D Ball { get; set; }
        public Texture2D Paddle { get; set; }
        public Texture2D Pixel { get; set; }

        public SoundEffect BallMiss { get; set; }
        public SoundEffect PaddleHit { get; set; }
        public SoundEffect Wallhit { get; set; }
        public SoundEffect BrickHit { get; set; }
        public SoundEffect BallLaunch { get; set; }

        public SpriteFont Helvetica;
       
        public GameContent(ContentManager Content)
        {
            //This loads the Textures we imported from the pipeline tool
            Paddle = Content.Load<Texture2D>("Paddle");
            Ball = Content.Load<Texture2D>("Ball");
            Pixel = Content.Load<Texture2D>("pixel");
            BrickTexture = Content.Load<Texture2D>("Brick (1)");
            
            ////This loads the Sounds we imported from the pipeline tool
            BrickHit = Content.Load<SoundEffect>("BrickBreak");
            BallMiss = Content.Load<SoundEffect>("BallMiss");
            PaddleHit = Content.Load<SoundEffect>("PaddleBounce");
            Wallhit = Content.Load<SoundEffect>("WallBounce");
            BallLaunch = Content.Load<SoundEffect>("LaunchBall");
            // This loads the Font 
           Helvetica = Content.Load<SpriteFont>("Helvetica");

        }
    }
}
