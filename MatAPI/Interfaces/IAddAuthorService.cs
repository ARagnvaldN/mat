using MatAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Interfaces
{
    interface IAddAuthorService
    {
        AddAuthorServiceResponse AddAuthor(AddAuthorServiceRequest request);
    }
}
