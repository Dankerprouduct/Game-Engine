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
        public Cipher game; 
        public Bitmap picture; 
        public Form1()
        {
            InitializeComponent();
            this.Text = "Cipher Game Engine";

            game = new Cipher(this, 600, 500); 

            
            picture = game.LoadBitmap(@"C:\Users\David\Pictures\Screenshots\Screenshot (203).png");
            if (picture == null)
            {
                MessageBox.Show("Error loading picture");
                Environment.Exit(0);
            }

            game.Device.DrawImage(picture, 10, 10);
            game.Update(); 
        }

        public void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            game = null; 
        }

        

        


    }
}
