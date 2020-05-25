using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AEV7.Common
{
    public static class ImgByteConverter
    {
        /// <summary>
        /// Convierte una secuencia de bytes a un Image Stream.
        /// </summary>
        /// <param name="array">Array de bytes a convertir</param>
        /// <returns>Stream con la Imagen</returns>
        public static MemoryStream ByteToImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            return ms;
        }

        /// <summary>
        /// Convierte una imagen a una secuencia (array) de bytes.
        /// </summary>
        /// <param name="imagenIn">Imagen a convertir</param>
        /// <returns>Array de bytes (byte[])</returns>
        public static byte[] ImageToByte(Image imagenIn)
        {
            MemoryStream ms = new MemoryStream();
            imagenIn.Save(ms, ImageFormat.Png);

            return ms.ToArray();
        }
    }
}
