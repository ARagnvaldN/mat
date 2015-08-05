using MatAPI.Types;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mat.Contexts
{
    public class MatContext: DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<RecipeItem> RecipeItems { get; set; }
    }
}
