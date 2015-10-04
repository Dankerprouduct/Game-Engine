using System;
using System.Drawing;
using CipherEngine; 

namespace Game_Engine
{
    class Sprite
    {

        public enum AnimateDirection
        {
            None = 0,
            Forward = 1,
            Backward = -1
        }

        public enum AnimateWrap
        {
            Wrap = 0,
            Bounce = 1
        }

        private Cipher game;
        private PointF position;
        private PointF velocity;
        private Size size;
        private Bitmap bitmap;
        private bool alive;
        private int colums;
        private int totalFrames;
        private int currentFrame;
        private AnimateDirection animateDirection;
        private AnimateWrap animateWrap;
        private int lastTime;
        private int animationRate;


        public Sprite(ref Cipher cipher)
        {
            game = cipher;
            position = new PointF(0, 0);

            velocity = new PointF(0, 0);
            size = new Size(0, 0);
            bitmap = null;
            alive = true;
            colums = 1;
            totalFrames = 1;
            currentFrame = 0;
            animateDirection = AnimateDirection.Forward;
            animateWrap = AnimateWrap.Wrap;
            lastTime = 0;
            animationRate = 30; 
        }

        public bool Alive
        {
            get
            {
                return alive;
            }
            set
            {
                alive = value; 
            }
        }
        public Bitmap Image
        {
            get
            {
                return bitmap;
            }
            set
            {
                bitmap = value; 
            }
        }
        public PointF Position
        {
            get
            {
                return position; 
            }
            set
            {
                position = value; 
            }
        }
        public PointF Velocity
        {
            get
            {
                return velocity;
            }
            set
            {
                velocity = value; 
            }
        }
        public float X
        {
            get
            {
                return position.X;
            }
            set
            {
                position.X = value;
            }
            
        }
        public float Y
        {
            get
            {
                return position.Y;
            }
            set
            {
                position.Y = value;
            }
        }
    }

}
