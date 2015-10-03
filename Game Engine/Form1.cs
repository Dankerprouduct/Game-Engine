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
        public Form1()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 20;
            timer.Enabled = true;
            timer.Tick += new EventHandler(Update); 
        }

        void Update(object source, EventArgs e)
        {
            Console.WriteLine("update"); 
        }
    }
}
