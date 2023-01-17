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

        public MessageLogger() { }

        public void ReadAll()
        {
            for(int i=0; i<Messages.Length; i++)
            {
                Console.WriteLine(Messages[i]);
            }
        }

        public void Clear()
        {
            for(int i=0;i<Messages.Length;i++)
            {
                Array.Clear(Messages);
            }
        }

        public Message Write(Message message)
        {
           
            return message;
        }
    }
}

