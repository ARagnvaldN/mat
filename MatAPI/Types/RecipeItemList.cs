using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Types
{
    public class RecipeItemList: List<RecipeItem>
    {
        public override string ToString()
        {
            string sOut = "";

            foreach (RecipeItem ri in this)
            {
                sOut += ri.ToString() + "\n";
            };

            return sOut;
        }
    }
}
