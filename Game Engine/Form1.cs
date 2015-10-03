using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Engine
{
    public partial class Form1 : Form
    {
        Timer timer;
        PictureBox pictureBox;
        Bitmap surface;
        Graphics graphics;

        string version; 
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(600, 500);

            timer = new Timer();
            timer.Interval = 20;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Update);

            pictureBox = new PictureBox();
            pictureBox.Parent = this;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.BackColor = Color.SkyBlue;

            surface = new Bitmap(this.Size.Width, this.Size.Height);
            pictureBox.Image = surface;
            graphics = Graphics.FromImage(surface);


            version = "1.00";

            Start(); 

        }

        void Start()
        {
            Font font = new Font("Ariel", 14, FontStyle.Regular, GraphicsUnit.Point);
            graphics.DrawString(version, font, Brushes.Black, 5, 5); 
 
        }

        int i;
        void Update(object source, EventArgs e)
        {
            Console.WriteLine("update " + i);
            i++; 
        }
    }
}
