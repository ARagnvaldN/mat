using Mat.Contexts;
using MatAPI.Interfaces;
using MatAPI.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Services
{
    public class DropDBService: IDropDBService
    {
        public DropDBServiceResponse DropDB(DropDBServiceRequest request)
        {
            DropDBServiceResponse response = new DropDBServiceResponse();
            response.ID = request.ID;

            using (var db = new MatContext())
            {
                db.Database.Delete();
                db.SaveChanges();
            }

            response.Result = AbstractServiceResponse.flag.SUCCESS;
            return response;
        }
    }
}
