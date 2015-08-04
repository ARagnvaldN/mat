using MatAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Requests
{
    public class AddIngredientServiceRequest: AbstractServiceRequest
    {
        public Ingredient Ingredient { get; set; }
    }
}
