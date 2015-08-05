﻿using MatAPI.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Requests
{
    public class GetRecipeServiceResponse: AbstractServiceResponse
    {
        public IEnumerable<Recipe> Recipes { get; set; }
    }
}
