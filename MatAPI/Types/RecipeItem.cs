using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Types
{
    public class RecipeItem
    {
        public int ID { get; set; }
        public Ingredient Item { get; set; }
        public double Quantity { get; set; }

        public override string ToString()
        {
            return ID + ": " + Item.name + " - " + Item.description + " " + Quantity + " " + Item.Measure;
        }
        public override bool Equals(object obj)
        {
            if (obj is RecipeItem)
            {
                RecipeItem i = (RecipeItem)obj;
                return i.ID == ID;
            }

            return false;
        }
    }
}
