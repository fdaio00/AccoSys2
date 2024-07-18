using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AccountingPR.Global
{

    public  class clsUtil
    {

        public static Bitmap ByteToImage(byte[] logo)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = logo;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }

        public static byte[] ImageToByte(PictureBox image)
        {
            try
            {
                byte[] imageBytes = null;
                if (image != null && image.Image!=null )
                {

                    MemoryStream ms = new MemoryStream();
                    image.Image.Save(ms, image.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                return imageBytes;
            }
            catch (Exception ex)
            {

                LogError(ex);
                
                return null;
                
            }
        }

        public static void LogError(Exception ex)
        {
            string debugFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
            if (!Directory.Exists(debugFolder))
            {
                Directory.CreateDirectory(debugFolder);
            }

            string logFilePath = Path.Combine(debugFolder, "error_log.txt");
            string errorMessage = $"{DateTime.Now}: {ex.Message}{Environment.NewLine}{ex.StackTrace}{Environment.NewLine}";

            File.AppendAllText(logFilePath, errorMessage);
        }

        public  void TextBoxEnter(object sender , EventArgs e)
        {
            TextBox temp = (TextBox)sender;
            temp.BackColor = Color.LightYellow;
            temp.SelectAll(); temp.Focus();
        }
    }
}
