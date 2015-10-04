using System;
using System.Drawing;
using CipherEngine; 

namespace Game_Engine
{
    class Sprite
    {

        public enum AnimateDir
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
        private Size mSize;
        private Bitmap bitmap;
        private bool alive;
        private int colums;
        private int totalFrames;
        private int currentFrame;
        private AnimateDir animateDirection;
        private AnimateWrap animateWrap;
        private int lastTime;
        private int animationRate;


        public Sprite(ref Cipher cipher)
        {
            game = cipher;
            position = new PointF(0, 0);

            velocity = new PointF(0, 0);
            mSize = new Size(0, 0);
            bitmap = null;
            alive = true;
            colums = 1;
            totalFrames = 1;
            currentFrame = 0;
            animateDirection = AnimateDir.Forward;
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
        public Size size
        {
            get
            {
                return mSize;
            }
            set
            {
                mSize = value;
            }
        }
        public int Width
        {
            get
            {
                return mSize.Width;
            }
            set
            {
                mSize.Width = value;
            }
        }
        public int Height
        {
            get
            {
                return mSize.Height;
            }
            set
            {
                mSize.Height = value;
            }
        }
        public int Columns
        {
            get
            {
                return colums;
            }
            set
            {
                colums = value; 
            }
        }
        public int TotalFrames
        {
            get
            {
                return totalFrames;
            }
            set
            {
                totalFrames = value;
            }
        }
        public int CurrentFrame
        {
            get
            {
                return currentFrame;
            }
            set
            {
                currentFrame = value;
            }
        }

        public AnimateDir AnimateDirection
        {
            get
            {
                return animateDirection;
            }
            set
            {
                animateDirection = value;
            }
        }
        public AnimateWrap AnimateWrapMode
        {
            get
            {
                return animateWrap;
            }
            set
            {
                animateWrap = value;
            }
        }
        public int AnimationRate
        {
            get
            {
                return (1000 / animationRate);
            }
            set
            {
                if (value == 0)
                {
                    value = 1;
                }
                animationRate = 1000 / value; 
            }
        }
        public void Animate()
        {
            Animate(0, totalFrames - 1); 
        }
        public void Animate(int startFrame, int endFrame)
        {
            if (totalFrames <= 0)
            {
                return;
            }

            int time = Environment.TickCount;
            if (time > lastTime + animationRate)
            {
                lastTime = time;

                currentFrame += (int)animateDirection;
                switch (animateWrap)
                {
                    case AnimateWrap.Wrap:
                        {
                            if (currentFrame < startFrame)
                            {
                                currentFrame = endFrame; 
                            }
                            else if (currentFrame > endFrame)
                            {
                                currentFrame = startFrame;
                            }
                            break;
                        }
                    case AnimateWrap.Bounce:
                        {
                            if (currentFrame < startFrame)
                            {
                                currentFrame = startFrame;
                                animateDirection = AnimateDir.Forward;
                            }
                            else if (currentFrame > endFrame)
                            {
                                currentFrame = endFrame;
                                animateDirection = AnimateDir.Backward; 
                            }
                            break;
                        }
                }
            }
        }

        public void Draw()
        {
            Rectangle frame = new Rectangle();
            frame.X = (currentFrame % colums) * size.Width;
            frame.Y = (currentFrame / colums) * size.Height;
            frame.Width = size.Width;
            frame.Height = size.Height;
            game.Device.DrawImage(bitmap, Bounds, frame, GraphicsUnit.Pixel);
        }
        public Rectangle Bounds
        {
            get
            {
                Rectangle rect = new Rectangle((int)position.X, (int)position.Y, size.Width, size.Height);
                return rect;
            }
            
        }
        public bool IsColliding(ref Sprite other)
        {
            bool collision = Bounds.IntersectsWith(other.Bounds);
            return collision; 
        }
        
    }

}
