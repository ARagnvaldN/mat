using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mat.Types
{
    public class Ingredient
    {
        enum Measure { Volume, Mass };
        enum Section { Fruit, Meat, Produce, Bread, Frozen, Dry, Snack };

        UInt16 ID { get; private set; }

        string name { get; set; }

        Section Section { get; set; }
        List<Product> Products { get; set; }

        double Quantity { get; set; }
        Measure Measure { get; set; }

    }
}
