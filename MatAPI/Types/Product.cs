using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Types
{
    public class Product
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int BarCode { get; set; }

        public override string ToString()
        {
            return Name + " " + BarCode;
        }

    }
}
