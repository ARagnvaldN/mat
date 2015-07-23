using Mat.Contexts;
using Mat.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new RecipeIngredientContext())
            {
                // Create and save a new Blog 
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var recipe = new Recipe { Name = name };
                db.Recipes.Add(recipe);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.Recipes
                            orderby b.Name
                            select b;

                Console.WriteLine("All blogs in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } 
        }
    }
}
