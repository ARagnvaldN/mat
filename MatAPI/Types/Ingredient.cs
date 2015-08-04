using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Types
{
    public class Ingredient
    {
        public enum EMeasure { Liter, Kg };
        public enum ESection { Fruit, Meat, Produce, Bread, Frozen, Dry, Snack };

        public int ID { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public ESection Section { get; set; }
        public List<Product> Products { get; set; }
        public EMeasure Measure { get; set; }

        public override string ToString()
        {
            return ID + ": " + name + " - " + description +" "+ Measure;
        }
        public override bool Equals(object obj)
        {
            if (obj is Ingredient){
                Ingredient i = (Ingredient)obj;
                return i.name == name;
            }

            return false;
        }
    }
}
