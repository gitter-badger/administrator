using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Text;

namespace Administrator
{
    public static class Utils
    {
        public static bool CheckConnection(string connectionString)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch 
            {
                return false;
            }
        }

        public static byte[] ImgToBytes(Image img)
        {
            if(img == null) return null;

            byte[] result;

            using(MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                result = ms.GetBuffer();
            }

            return result;
        }

        public static Image BytesToImg(byte[] imgBytes)
        {
            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                return Image.FromStream(ms);
            }
        }

        public static GraphicsPath CreateRoundedRectPath(Rectangle r, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddLine(r.Left + radius, r.Top, r.Left + r.Width - radius * 2, r.Top);
            path.AddArc(r.Left + r.Width - radius * 2, r.Top, radius * 2, radius * 2, 270, 90);
            path.AddLine(r.Left + r.Width, r.Top + radius, r.Left + r.Width, r.Top + r.Height - radius * 2);
            path.AddArc(r.Left + r.Width - radius * 2, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(r.Left + r.Width - radius * 2, r.Top + r.Height, r.Left + radius, r.Top + r.Height);
            path.AddArc(r.Left, r.Top + r.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.AddLine(r.Left, r.Top + r.Height - radius * 2, r.Left, r.Top + radius);
            path.AddArc(r.Left, r.Top, radius * 2, radius * 2, 180, 90);
            path.CloseFigure();
            return path;
        }

        public static string GetDbName(string connectionString)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            return builder.InitialCatalog.ToLower();
        }

        public static string FirstLatterToUpper(string text)
        {
            if (text == null || text.Length < 1) return text;

            StringBuilder builder = new StringBuilder(text);
            builder[0] = builder[0].ToString().ToUpperInvariant().ToCharArray()[0];

            return builder.ToString();
        }
    }
}
