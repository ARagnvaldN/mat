using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mat.Types
{
    public class Author
    {
        public UInt16 ID { get; set; }
        public string name { get; set; }
        public List<Recipe> Recipes { get; set; }

    }
}
