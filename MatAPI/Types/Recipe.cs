using MatAPI.Types;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Types
{
    public class Recipe
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Procedure { get; set; }
        public virtual RecipeItemList Ingredients { get; set; }
        public virtual Author Author { get; set; }
        public byte[] Image { get; set; }
                
        public override string ToString()
        {
            return Name + ": " + ID + "\n-------------\n" + Ingredients;// +Description + "\n" + Ingredients + "\n" + Procedure + "\n" + Author;
        }
    }
}
