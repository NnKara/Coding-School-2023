using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07

{
    public enum ActionEnum
    {
        Convert,
        Uppercase,
        Reverse
    }
    internal class ActionRequest:ActionResolver
    {
        public Guid RequestID { get; set; }
        public String? Input { get; set; }
        public ActionEnum Action { get; set; }

        public ActionRequest() { }    
        

        public ActionRequest(String input)
        {
            Input = input;
        }

        public ActionRequest(Guid requestId, String input, ActionEnum action)
        {
            RequestID = requestId;
            Input = input;
            Action = action;
        }         
    }
}