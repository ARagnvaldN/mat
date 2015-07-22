using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat.Types
{
    public class Recipe
    {
        public UInt16 ID { get; private set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Procedure { get; set; }
        public virtual List<Ingredient> Ingredients { get; set; }
        public virtual Author Author { get; set; }
        public Bitmap Image { get; set; }


    }
}
