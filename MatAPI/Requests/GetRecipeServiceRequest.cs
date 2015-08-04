using MatAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Requests
{
    public class GetRecipeServiceRequest: AbstractServiceRequest
    {
        public int SearchID { get; set; }
        public string RecipeName { get; set; }
        public IEnumerable<Author> RecipeAuthor { get; set; }
        public IEnumerable<Ingredient> RecipeIngredients { get; set; }

    }
}
