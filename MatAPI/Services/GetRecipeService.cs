using Mat.Contexts;
using MatAPI.Types;
using MatAPI.Interfaces;
using MatAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Services
{
    public class GetRecipeService: IGetRecipeService
    {
       public GetRecipeServiceResponse GetRecipes(GetRecipeServiceRequest request)
       {

           List<Recipe> result = new List<Recipe>();

           using (var db = new MatContext())
           {
               var query = from r in db.Recipes
                           orderby r.Name
                           select r;

               var rec = (from r in db.Recipes
                           select r).First();

               Console.WriteLine("test: " +rec.Ingredients[0].Item);

               foreach(Recipe r in query){
                   Console.WriteLine(r.Ingredients);
                   result.Add(r);
               }
               
           }

           GetRecipeServiceResponse response = new GetRecipeServiceResponse();
           response.ID = request.ID;
           response.Result = AbstractServiceResponse.flag.SUCCESS;
           response.Recipes = result;
           return response;
       
       }
    }
}
