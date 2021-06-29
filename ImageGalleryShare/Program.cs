using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryShare
{
    public class Program
    {
        public static void Main()
        {
            Gmail gmail = new Gmail();
            ImageGallery imagegallery1 = new ImageGallery(gmail);
            imagegallery1.share();

            WhatsApp whatsapp = new WhatsApp();
            ImageGallery imagegallery2 = new ImageGallery(whatsapp);
            imagegallery2.share();

            Bluetooth bluetooth = new Bluetooth();
            ImageGallery imagegallery3 = new ImageGallery(bluetooth);
            imagegallery3.share();
        }
    }
}
