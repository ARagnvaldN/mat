using MatAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Interfaces
{
    public interface IAddIngredientService
    {
        AddIngredientServiceResponse AddIngredient(AddIngredientServiceRequest request);
    }
}
