using Mat.Contexts;
using MatAPI.Interfaces;
using MatAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI
{
    public class AddRecipeService: IAddRecipeService
    {
        public AddRecipeServiceResponse AddRecipe(AddRecipeServiceRequest request)
        {
            if (request.Recipe == null)
                throw new ArgumentNullException();

            using (var db = new MatContext())
            {
                db.Recipes.Add(request.Recipe);
                db.SaveChanges();
            } 

            AddRecipeServiceResponse response = new AddRecipeServiceResponse();
            response.ID = request.ID;
            response.Result = AddRecipeServiceResponse.flag.SUCCESS;
            return response;
        }
    }
}
