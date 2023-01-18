using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class Message
    {
        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public String? MyMessage { get; set; }

        
        public Message() 
        {
            ID=Guid.NewGuid();
        }

        public Message(string myMessage)
        {
            ID= Guid.NewGuid();
            TimeStamp=DateTime.Now;
            MyMessage = myMessage;
        }
     
    }
}
