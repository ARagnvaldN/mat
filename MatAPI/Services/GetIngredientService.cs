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
    class GetIngredientService: IGetIngredientService
    {
    public GetIngredientServiceResponse GetIngredient(GetIngredientServiceRequest request)
    {
        List<Ingredient> result = new List<Ingredient>();

        using (var db = new MatContext())
        {
            var query = from i in db.Ingredients
                        orderby i.name
                        select i;

            foreach (Ingredient i in query)
            {
                result.Add(i);
            }
        }

        GetIngredientServiceResponse response = new GetIngredientServiceResponse();
        response.ID = request.ID;
        response.Result = AbstractServiceResponse.flag.SUCCESS;
        response.Ingredients = result;
        return response;
    }
}
}
