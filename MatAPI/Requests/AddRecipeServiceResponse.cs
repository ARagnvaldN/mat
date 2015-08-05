using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPI.Requests
{
    public class AddRecipeServiceResponse: AbstractServiceRequest
    {
        public enum flag { SUCCESS, FAILURE };
        public flag Result { get; set; }

        public int ID { get; set; }
    }
}
