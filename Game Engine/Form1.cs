using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CipherEngine;


namespace Game_Engine
{
    public partial class Form1 : Form
    {
        private bool gameOver;
        private int startTime = 0;
        private int currentTime = 0;
        private int frameCount = 0;
        private int frameTimer = 0;
        public float frameRate = 0; 

        private Cipher game;

        public Form1()
        {
            InitializeComponent();
                        
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            Console.WriteLine("Loaded"); 
            Main(); 
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Game_KeyPressed(e.KeyCode); 
        }
        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShutDown(); 
        }

        public bool GameInitialize()
        {
            this.Text = "Cipher Game Engine";
            // put junk here
            // im sorry not junk, your valuable sprites
            
            
            return true;
        }
        public void Main()
        {
            Form form = (Form)this;

            game = new Cipher(form, 800, 600);

            GameInitialize();

            while (!gameOver)
            {
                currentTime = Environment.TickCount;

                GameUpdate(currentTime - startTime);
                if (currentTime > startTime + 16)
                {
                    //update timing 
                    startTime = currentTime;

                    GameDraw();

                    Application.DoEvents();

                    game.Update(); 
                }
                frameCount++;

                if (currentTime > frameTimer + 1000)
                {
                    frameTimer = currentTime;
                    frameRate = frameCount;
                    frameCount = 0; 
                }
                
            }
            GameEnd();
            Application.Exit(); 
            
            
        }
        
        public void ShutDown()
        {
            gameOver = true; 
        }
        
        public void Game_KeyPressed(System.Windows.Forms.Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    {
                        Console.WriteLine("Up"); 
                        game.Print(new Point(10, 50), "Up");
                        break;
                    }
                case Keys.Down:
                    {
                        Console.WriteLine("Down");
                        game.Print(new Point(10, 70), "Down"); 
                        break;
                    }
                case Keys.Left:
                    {
                        Console.WriteLine("Left");
                        game.Print(new Point(10, 90), "Left");
                        break;
                    }
                case Keys.Right:
                    {
                        Console.WriteLine("Right");
                        game.Print(new Point(10, 110), "Right"); 
                        break;
                    }
            }
        }
        public void GameUpdate(int time)
        {

        }
        public void GameDraw()
        {
            game.SetFont("Ariel", 18, FontStyle.Regular);
            game.Print(new Point(10, 10), "Cipher Game Engine");

        }
        public void GameEnd()
        {

        }
        
    }
}
