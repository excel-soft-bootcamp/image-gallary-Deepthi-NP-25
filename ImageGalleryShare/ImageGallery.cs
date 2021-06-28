using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryShare
{
    public class ImageGallery
    {
        Iapplication iapplication;

        public ImageGallery(Iapplication gallery)
        {
            this.iapplication = gallery;
        }

        public void share()
        {
            iapplication.send();
        }

        
    }
}