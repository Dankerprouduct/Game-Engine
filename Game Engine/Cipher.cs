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
        private Font font; 
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
                
        public Graphics Device
        {
            get
            {
                return device; 
            }
        }
        // Font Support
        public void SetFont(string name, int size, FontStyle style)
        {
            font = new Font(name, size, style, GraphicsUnit.Pixel); 
        }
        public void Print(int x, int y, string text, Brush color)
        {
            Device.DrawString(text, font, color, (float)x, (float)y); 
        }
        public void Print(Point pos, string text, Brush color)
        {
            Print(pos.X, pos.Y, text, color); 
        }
        public void Print(int x, int y, string text)
        {
            Print(x, y, text, Brushes.White); 
        }
        public void Print(Point pos, string text)
        {
            Print(pos.X, pos.Y, text);
        }

        // Bitmap Support
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
        public void DrawBitmap(ref Bitmap bmp, float x, float y)
        {
            device.DrawImageUnscaled(bmp, (int)x, (int)y); 
        }
        public void DrawBitmap(ref Bitmap bmp, float x, float y, int width, int height)
        {
            device.DrawImageUnscaled(bmp, (int)x, (int)y, width, height); 
        }
        public void DrawBitmap(ref Bitmap bmp, Point pos)
        {
            device.DrawImageUnscaled(bmp, pos); 
        }

        public void Update()
        {
            picturebox.Image = surface;
        }
        
        
    }
    
    
    
}
