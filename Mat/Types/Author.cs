using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mat.Types
{
    class Author
    {
        UInt16 ID { get; private set; }
        string name { get; set; }
        List<Recipe> Recipes { get; set; }

    }
}
