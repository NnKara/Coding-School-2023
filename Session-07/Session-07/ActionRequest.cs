﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07

{
    internal class ActionRequest
    {
        public Guid RequestID { get; set; }
        public String? Input { get; set; }
        public ActionEnum Action { get; set; }

        public ActionRequest() 
        {
            RequestID= Guid.NewGuid();
        }

        
        

       
       
    }
}