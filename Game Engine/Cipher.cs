using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 
using System.Windows.Forms;
using System.Diagnostics; 
namespace CipherEngine
{
    class Cipher
    {
        private Form form1;
        private PictureBox picturebox;
        private Graphics device;
        private Bitmap surface; 
        public Cipher(Form form, int width, int height)
        {
            form1 = form;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Size = new Size(width, height);
            form.MaximizeBox = false;

            picturebox = new PictureBox();
            picturebox.Parent = form1;
            picturebox.Dock = DockStyle.Fill;
            picturebox.BackColor = Color.Black;

            surface = new Bitmap(form1.Size.Width, form1.Size.Height);
            picturebox.Image = surface;
            device = Graphics.FromImage(surface); 

            
            
        }
        ~Cipher()
        {
            Trace.WriteLine("Game class deconstructor");
            device.Dispose();
            surface.Dispose();
            picturebox.Dispose(); 
               
        }

        public Bitmap LoadBitmap(string filename)
        {
            Bitmap bmp = null;
            try
            {
                bmp = new Bitmap(filename);
                return bmp; 
            }
            catch (Exception ex)
            {
                return bmp;
            }
        }
        public Graphics Device
        {
            get
            {
                return device; 
            }
        }

        public void Update()
        {
            picturebox.Image = surface;
        }
        
        
    }
    
    
    
}
