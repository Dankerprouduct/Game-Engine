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
        private Cipher game; 
        public Form1()
        {
            InitializeComponent();
            
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            Main(); 
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Game_KeyPressed(e.KeyCode); 
        }
        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        public bool GameInitialize()
        {
            this.Text = "Cipher Game Engine";
            return true;
        }
        public void Main()
        {
            Form form = (Form)this;
            game = new Cipher(form, 800, 600);

            GameInitialize();

            while (true)
            {
                
            }
        }

        public void Game_KeyPressed(System.Windows.Forms.Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    {

                        break;
                    }
                case Keys.Down:
                    {

                        break;
                    }
                case Keys.Left:
                    {

                        break;
                    }
                case Keys.Right:
                    {

                        break;
                    }
            }
        }
        


    }
}
