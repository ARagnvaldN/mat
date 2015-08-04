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
    public class AddIngredientService: IAddIngredientService
    {
    public AddIngredientServiceResponse AddIngredient(AddIngredientServiceRequest request)
    {

        List<string> errors = new List<string>();

        AddIngredientServiceResponse response = new AddIngredientServiceResponse();
        response.ID = request.ID;
        response.Result = AbstractServiceResponse.flag.FAILURE;

        try
        {
         using (var db = new MatContext())
                {
                    if(db.Ingredients.Any(i => i.name == request.Ingredient.name))
                        throw new IngredientAlreadyInDbException();
                    db.Ingredients.Add(request.Ingredient);
                    db.SaveChanges();
                }
        }
        catch (IngredientAlreadyInDbException e)
        {
            //An ingredient of the same name is already in DB
            response.Result = AbstractServiceResponse.flag.FAILURE;
            errors.Add(e.Message);

        }
        finally
        {
            response.ErrorList = errors;
            if (errors.Count == 0)
                response.Result = AbstractServiceResponse.flag.SUCCESS;
        }

        
        return response;
    }
}
}
