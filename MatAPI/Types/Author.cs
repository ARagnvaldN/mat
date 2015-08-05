using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Types
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Recipe> Recipes { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            if (obj is Author){
                Author r = (Author) obj;
                return ID == r.ID;
            }
            
            return false;
        }
    }
}
