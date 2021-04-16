using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaniApp
{
    class Metodos
    {
        private static readonly ImageConverter _imageConverter = new ImageConverter();
        
        #region CONVERTIR IMAGENES Y VICEVERSA
        public static void AgregarFoto(PictureBox Foto)
        {
            Stream MyStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image file (*.jpe; *.jpeg;)| *.jpg; *.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((MyStream = openFileDialog.OpenFile()) != null)
                    {
                        string FileName = openFileDialog.FileName;
                        if (MyStream.Length > 512000)
                            MessageBox.Show("Limite de tamanio");
                        else
                            Foto.Load(FileName);
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
       
        public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }
        public static byte[] ImageToArray(PictureBox PbFoto)
        {
            MemoryStream Stream = new MemoryStream();
            PbFoto.Image.Save(Stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] pic = Stream.ToArray();
            return pic;

        }
        #endregion
        #region LimpiezaDatos
        public static void ClearForm(TextBox TextBox)
        {
            TextBox.Text = string.Empty;
        }
        #endregion
        public static string GetEdad(DateTime Fecha)
        {
            string edad;
            TimeSpan tS = new TimeSpan();
            tS = DateTime.Now.Subtract(Fecha);
            edad =Math.Floor((tS.TotalDays / 365)).ToString();                                       
            return edad;
        }
    }
}
