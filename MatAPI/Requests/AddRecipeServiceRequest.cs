using MatAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Requests
{
    public class AddRecipeServiceRequest: AbstractServiceRequest
    {
        
        public int ID {get; set;}
        public Recipe Recipe { get; set; }

    }
}
