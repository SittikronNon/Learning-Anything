using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Furniture
    {
        public string Color { get; set; }
        public string Material { get; set; }

        //Default Constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";
        }

        //Constructor

        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }


    }
}
