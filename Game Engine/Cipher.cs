using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; 

namespace CipherEngine
{
    class Cipher
    {
        public Cipher()
        {

        }
        
        
    }
    class Texture2D
    {
        Bitmap texture;
        public Texture2D(string filepath)
        {
            texture = Texture(filepath); 
        }
        public Bitmap Text
        {
            get
            {
                return texture; 
            }
            set
            {

            }
        }
        private Bitmap Texture(string filename)
        {
            Bitmap bitmap = null;

            try
            {
                bitmap = new Bitmap(filename);
                return bitmap;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return bitmap; 
            }
        }

    }
    
}
