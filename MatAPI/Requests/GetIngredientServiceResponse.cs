using MatAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Requests
{
    public class GetIngredientServiceResponse: AbstractServiceResponse
    {
        public IEnumerable<Ingredient> Ingredients { get; set; }
    }
}
