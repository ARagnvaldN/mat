using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatAPI.Requests
{
    public abstract class AbstractServiceResponse
    {
        public int ID { get; set; }
        public enum flag { SUCCESS, FAILURE };
        public flag Result { get; set; }
        public IEnumerable<string> ErrorList { get; set; }
    }
}
