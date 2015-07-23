using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mat.Types
{
    public class Ingredient
    {
        public enum EMeasure { Volume, Mass };
        public enum ESection { Fruit, Meat, Produce, Bread, Frozen, Dry, Snack };

        public int ID { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public ESection Section { get; set; }
        public List<Product> Products { get; set; }

        public double Quantity { get; set; }
        public EMeasure Measure { get; set; }

    }
}
