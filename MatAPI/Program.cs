using Mat.Contexts;
using MatAPI.Types;
using MatAPI.Requests;
using MatAPI.Services;
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
            //Initialize services, should use dependency  injection (unity)
            AddRecipeService sAdd = new AddRecipeService();
            GetRecipeService sGet = new GetRecipeService();
            AddIngredientService sAddIng = new AddIngredientService();
            GetIngredientService sGetIng = new GetIngredientService();
            DropDBService sDrop = new DropDBService();


            //Drop the database, probably should be removed before release
            DropDBServiceRequest dropReq = new DropDBServiceRequest { ID = 1};
            DropDBServiceResponse dropRe = sDrop.DropDB(dropReq);
            
            
            //Add a test ingredient
            Ingredient ing = new Ingredient { name = "Mjölk", description = "Mjölk av ko.",Measure = Ingredient.EMeasure.Liter };
            AddIngredientServiceRequest addIngSr = new AddIngredientServiceRequest { ID = 1, Ingredient = ing };

            AddIngredientServiceResponse reIngAdd = sAddIng.AddIngredient(addIngSr);

            //Get a list of all ingredients
            GetIngredientServiceRequest getISR = new GetIngredientServiceRequest { ID = 1 };
            GetIngredientServiceResponse reGetI = sGetIng.GetIngredient(getISR);
            Console.WriteLine("Ingredients: ");
            foreach (Ingredient i in reGetI.Ingredients)
            {
                Console.WriteLine(i);
            }

            //Add a recipe
            RecipeItem rItem = new RecipeItem();
            rItem.Item = ing;
            rItem.Quantity = 1.0f;
            RecipeItemList rIList = new RecipeItemList();
            rIList.Add(rItem);
            var recipe = new Recipe { Name = "Pannkakor", Ingredients = rIList };
            var addSR = new AddRecipeServiceRequest { Recipe = recipe, ID = 1 };

            AddRecipeServiceResponse re = sAdd.AddRecipe(addSR);

           
            //Get a list of all the recipes
            GetRecipeServiceRequest getSR = new GetRecipeServiceRequest { ID = 1 };
            GetRecipeServiceResponse reGet = sGet.GetRecipes(getSR);

            Console.WriteLine("Recipes: ");
            foreach (Recipe r in reGet.Recipes)
            {
                Console.WriteLine(r);
            }

            Console.ReadKey();

        }
        

        void addRecipe(Recipe recipe)
        {
            
        }
    }
}
