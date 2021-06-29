using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryShare
{
    public class Gmail : IApplication
    {
        public void send()
        {
            Console.WriteLine("Image sent through Gmail");

        }
    }
}