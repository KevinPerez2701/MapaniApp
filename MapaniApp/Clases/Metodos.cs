using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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

        public static void databaseFilePut(string varFilePath, ContactAsesoria File)
        {
           
            using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                   File.PDF = reader.ReadBytes((int)stream.Length);
                }
            }
           
        }
        public static void databaseFileRead(ContactAsesoria blob)
        {

            {
                            SaveFileDialog svg = new SaveFileDialog();
                            svg.ShowDialog();
                            using (var fs = new FileStream(svg.FileName + ".pdf", FileMode.Create,FileAccess.Write))
                            fs.Write(blob.PDF, 0, (blob.PDF).Length);
             }

       }
        
        public static void GuardarFoto(PictureBox Foto)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
           
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                Foto.Image.Save(sfd.FileName, format);
            }
        }
        public static void AgregarFoto(PictureBox Foto)
        {
            Stream MyStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "image file (*.jpe; *.jpeg; )| *.jpg; *.jpeg;";
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
        #region LIMPIEZA DE DATOS
        public static void ClearForm(TextBox TextBox)
        {
            TextBox.Text = string.Empty;
        }
        #endregion
        #region CALCULO EDAD
        public static string GetEdad(DateTime Fecha, DateTime Cita)
        {
            string edad;
            TimeSpan tS = new TimeSpan();
            tS = Cita.Subtract(Fecha);          
            edad = Math.Floor(tS.TotalDays).ToString();
            return edad;
        }

        public static string GetEdadMeses(DateTime Fecha, DateTime Cita)
        {
            double calculo;
            string edad;
            // calculo = (Cita.Month - Fecha.Month) + 12 * (Cita.Year - Fecha.Year);
            calculo = Cita.Subtract(Fecha).Days / (365.25 / 12);
            edad = Math.Round(calculo, 2).ToString();              
            return edad;
        }
        public static string GetEdadAnhos(DateTime Fecha)
        {
            string edad;
            TimeSpan tS = new TimeSpan();
            tS = DateTime.Now.Subtract(Fecha);
            edad =Math.Floor((tS.TotalDays / 365)).ToString();
            return edad;
        }
        public static string ObtenerEdad(DateTime birthday)
        {
            var now = DateTime.Now;

            var yearsOld = now - birthday;
            int years = (int)(yearsOld.TotalDays / 365.25);
            int months = (int)(((yearsOld.TotalDays / 365.25) - years) * 12);

            return $"{years} Años {(months > 0 ? $"y {months} meses" : "")}";
        }
        #endregion

    }
}
