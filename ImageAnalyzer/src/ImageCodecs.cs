using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RockMaker.Business.PlateView.Imaging
{
    public enum ImageCompression
    {
        DotNetJpeg411,
        WICHDPhoto,
        DotNetPng,
        DotNetTiff,
        DotNetGif,
        DotNetBmp,
    }

    public class ImageCodecs
    {
        public SortedList imageCodecs = new SortedList();

        public static readonly ImageCodecs Instance = new ImageCodecs();

        protected ImageCodecs()
        {
            imageCodecs.Add(ImageCompression.DotNetJpeg411, new DotNetJpeg411ImageCodec());
            imageCodecs.Add(ImageCompression.DotNetPng, new DotNetPngImageCodec());
            imageCodecs.Add(ImageCompression.DotNetTiff, new DotNetTiffImageCodec());
            imageCodecs.Add(ImageCompression.DotNetGif, new DotNetGifImageCodec());
            imageCodecs.Add(ImageCompression.DotNetBmp, new DotNetBmpImageCodec());
        }

        public ImageCodec this[ImageCompression imageCompression]
        {
            get { return (ImageCodec)imageCodecs[imageCompression]; }
        }

        public ImageCodec this[ImageFormat imageFormat]
        {
            get
            {
                foreach (ImageCodec imageCodec in Instance.imageCodecs.Values)
                {
                    if (imageCodec.guid.Equals(imageFormat.Guid))
                        return imageCodec;
                }
                return (ImageCodec)Instance.imageCodecs[ImageCompression.DotNetJpeg411];
            }
        }


        public ImageCodec this[String extension]
        {
            get
            {
                foreach (ImageCodec imageCodec in Instance.imageCodecs.Values)
                {
                    if (imageCodec.Extension == extension)
                        return imageCodec;
                }

                // If all else fails, return the suite of .NET codecs.  This'll allow us maximum
                // flexibility for the loading of image file formats if, for example, someone drags
                // and drops an image onto plate viewer.
                return (ImageCodec)Instance.imageCodecs[ImageCompression.DotNetJpeg411];
            }
        }
    }



    public abstract class ImageCodec
    {
        public abstract String Extension { get; }
        public abstract Guid guid { get; }

        public abstract Image Load(String fileName);
        public abstract Image Load(Stream stream);
        public abstract void Save(Image image, String fileName);
        public abstract void Save(Image image, Stream stream);
    }

    /// <summary>
    /// Support for the .NET standard JPEG image compressor.
    /// </summary>
    public class DotNetJpeg411ImageCodec : ImageCodec
    {
        private static ImageCodecInfo dotNetCodec;
        private static EncoderParameters dotNetEncoderParams = new EncoderParameters(1);

        public override string Extension { get { return ".jpg"; } }
        public override Guid guid { get { return ImageFormat.Jpeg.Guid; } }

        public static EncoderParameters DotNetEncoderParams
        {
            get
            {
                return dotNetEncoderParams;
            }
            set
            {
                dotNetEncoderParams = value;
            }
        }

        public DotNetJpeg411ImageCodec()
        {
            // Find standard jpeg encoder.
            foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders())
            {
                if (encoder.MimeType == "image/jpeg")
                    dotNetCodec = encoder;
            }

            int quality = 1;
            dotNetEncoderParams.Param[0] = new EncoderParameter(Encoder.Quality, quality);
        }

        public override Image Load(string fileName)
        {
            Image image = null;
            try
            {
                using (var fileStream = File.OpenRead(fileName))
                {
                    using (Image tempImage = Image.FromStream(fileStream))
                    {
                        image = new Bitmap(tempImage);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + ": " + fileName);
            }
            return image;
        }

        public override Image Load(Stream stream)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromStream(stream); }
            catch { }
            return image;
        }

        public override void Save(Image bitmap, string fileName)
        {
            bitmap.Save(fileName, dotNetCodec, dotNetEncoderParams);
        }

        public override void Save(Image image, Stream stream)
        {
            image.Save(stream, dotNetCodec, dotNetEncoderParams);
        }
    }


    /// <summary>
    /// Support for the .NET PNG compressor.
    /// </summary>
    public class DotNetPngImageCodec : ImageCodec
    {
        private static ImageCodecInfo dotNetCodec;
        private static EncoderParameters dotNetEncoderParams = new EncoderParameters(1);

        public override string Extension { get { return ".png"; } }
        public override Guid guid { get { return ImageFormat.Png.Guid; } }

        public static EncoderParameters DotNetEncoderParams
        {
            get
            {
                return dotNetEncoderParams;
            }
            set
            {
                dotNetEncoderParams = value;
            }
        }

        public DotNetPngImageCodec()
        {
            // Find standard jpeg encoder.
            foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders())
            {
                if (encoder.MimeType == "image/png")
                    dotNetCodec = encoder;
            }

            dotNetEncoderParams.Param[0] = new EncoderParameter(Encoder.Quality, 10L);
        }

        public override Image Load(string fileName)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromFile(fileName); }
            catch { }
            return image;
        }

        public override Image Load(Stream stream)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromStream(stream); }
            catch { }
            return image;
        }

        public override void Save(Image bitmap, string fileName)
        {
            bitmap.Save(fileName, dotNetCodec, dotNetEncoderParams);
        }

        public override void Save(Image image, Stream stream)
        {
            image.Save(stream, dotNetCodec, dotNetEncoderParams);
        }
    }

    /// <summary>
    /// Support for the .NET tif compressor.
    /// </summary>
    public class DotNetTiffImageCodec : ImageCodec
    {
        private static ImageCodecInfo dotNetCodec;
        private static EncoderParameters dotNetEncoderParams = new EncoderParameters(1);

        public override string Extension { get { return ".tif"; } }
        public override Guid guid { get { return ImageFormat.Tiff.Guid; } }

        public static EncoderParameters DotNetEncoderParams
        {
            get
            {
                return dotNetEncoderParams;
            }
            set
            {
                dotNetEncoderParams = value;
            }
        }

        public DotNetTiffImageCodec()
        {
            // Find standard jpeg encoder.
            foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders())
            {
                if (encoder.MimeType == "image/tiff")
                    dotNetCodec = encoder;
            }

            //int quality = SystemProperties.Get( "ImageManager.CompressionQuality" ).Int;
            dotNetEncoderParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)EncoderValue.CompressionNone);
        }

        public override Image Load(string fileName)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromFile(fileName); }
            catch { }
            return image;
        }

        public override Image Load(Stream stream)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromStream(stream); }
            catch { }
            return image;
        }

        public override void Save(Image bitmap, string fileName)
        {
            bitmap.Save(fileName, dotNetCodec, dotNetEncoderParams);
        }

        public override void Save(Image image, Stream stream)
        {
            image.Save(stream, dotNetCodec, dotNetEncoderParams);
        }
    }

    /// <summary>
    /// Support for the .NET gif compressor.
    /// </summary>
    public class DotNetGifImageCodec : ImageCodec
    {
        private static ImageCodecInfo dotNetCodec;
        private static EncoderParameters dotNetEncoderParams = new EncoderParameters(1);

        public override string Extension { get { return ".gif"; } }
        public override Guid guid { get { return ImageFormat.Gif.Guid; } }

        public static EncoderParameters DotNetEncoderParams
        {
            get
            {
                return dotNetEncoderParams;
            }
            set
            {
                dotNetEncoderParams = value;
            }
        }

        public DotNetGifImageCodec()
        {
            // Find standard jpeg encoder.
            foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders())
            {
                if (encoder.MimeType == "image/gif")
                    dotNetCodec = encoder;
            }

            //int quality = SystemProperties.Get( "ImageManager.CompressionQuality" ).Int;
            dotNetEncoderParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)EncoderValue.CompressionNone);
        }

        public override Image Load(string fileName)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromFile(fileName); }
            catch { }
            return image;
        }

        public override Image Load(Stream stream)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromStream(stream); }
            catch { }
            return image;
        }

        public override void Save(Image bitmap, string fileName)
        {
            bitmap.Save(fileName, dotNetCodec, dotNetEncoderParams);
        }

        public override void Save(Image image, Stream stream)
        {
            image.Save(stream, dotNetCodec, dotNetEncoderParams);
        }
    }

    /// <summary>
    /// Support for the .NET bmp compressor.
    /// </summary>
    public class DotNetBmpImageCodec : ImageCodec
    {
        private static ImageCodecInfo dotNetCodec;
        private static EncoderParameters dotNetEncoderParams = new EncoderParameters(1);

        public override string Extension { get { return ".bmp"; } }
        public override Guid guid { get { return ImageFormat.Bmp.Guid; } }

        public static EncoderParameters DotNetEncoderParams
        {
            get
            {
                return dotNetEncoderParams;
            }
            set
            {
                dotNetEncoderParams = value;
            }
        }

        public DotNetBmpImageCodec()
        {
            // Find standard jpeg encoder.
            foreach (ImageCodecInfo encoder in ImageCodecInfo.GetImageEncoders())
            {
                if (encoder.MimeType == "image/bmp")
                    dotNetCodec = encoder;
            }

            //int quality = SystemProperties.Get( "ImageManager.CompressionQuality" ).Int;
            dotNetEncoderParams.Param[0] = new EncoderParameter(Encoder.Quality, (long)EncoderValue.CompressionNone);
        }

        public override Image Load(string fileName)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromFile(fileName); }
            catch { }
            return image;
        }

        public override Image Load(Stream stream)
        {
            Image image = null;
            try { image = System.Drawing.Image.FromStream(stream); }
            catch { }
            return image;
        }

        public override void Save(Image bitmap, string fileName)
        {
            bitmap.Save(fileName, dotNetCodec, dotNetEncoderParams);
        }

        public override void Save(Image image, Stream stream)
        {
            image.Save(stream, dotNetCodec, dotNetEncoderParams);
        }
    }

}
