using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class MessageLogger
    {
        public Message[]? Messages { get; set; }
        private int _counter = 0;
        

        public MessageLogger() 
        {
            Messages = new Message[1000];
        }

        

        public void ReadAll()
        {
         foreach(Message message in Messages) 
            {
                if(message != null)
                {
                    Console.WriteLine(message.MyMessage);
                }
            }   
        }

        public void Clear()
        {

        }

        public void Write(Message message)
        {
            Messages[_counter] = message;
            _counter++;
           
        }
    }
}

