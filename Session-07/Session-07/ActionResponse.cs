using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class ActionResponse:ActionResolver
    {
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }
        public String? Output { get; set; } 

        public ActionResponse() { }

        public ActionResponse(Guid requestId,Guid responseId,String output) 
        {
            RequestID = requestId;
            ResponseID = responseId;
            Output = output;
        }       
    }
}
