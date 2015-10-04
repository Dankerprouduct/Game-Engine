using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherEngine;

namespace CipherEngine
{
    class Physics
    {
        enum Gravity
        {
            Light, 
            Heavy, 
            Normal
        }

        private float velocityX;
        private float velocityY;
        private float weight; 
        private Gravity gravity; 
        private Sprite sprite;
        private float minXVelocity;
        private float minYVelocity;
        public Physics(ref Sprite other)
        {
            
            velocityX = 0;
            velocityY = 0;
            minYVelocity = 0;
            minXVelocity = 0; 
            weight = 1;
            sprite = other; 
            gravity = Gravity.Normal;

            SpritePhysics(); 
        }

        public Gravity GravityType
        {
            get
            {
                return gravity;
            }
            set
            {
                gravity = value; 
            }
        }
        public float SetGravity
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value; 
            }
        }

        public float MinXVelocity
        {
            get
            {
                return minXVelocity;
            }
            set
            {
                minYVelocity = value;
            }
        }
        public float MinYVelocity
        {
            get
            {
                return minYVelocity;
            }
            set
            {
                minYVelocity = value;
            }
        }

        private void SpritePhysics()
        {
            switch (gravity)
            {
                case Gravity.Heavy:
                    {
                        weight = 3;
                        break;
                    }
                case Gravity.Light:
                    {
                        weight = 1;
                        break;
                    }
                case Gravity.Normal:
                    {
                        weight = 2; 
                        break; 
                    }
            }
        }
        public void Update()
        {

            velocityY = velocityY - (weight * .05f);
            velocityX = velocityX - (weight * .05f);
            if (velocityX <= 0)
            {
                velocityX = 0;
            }
            if (velocityY <= 0)
            {
                velocityY = 0; 
            }
        }
        
    }
}
