using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07
{
    internal class StringParser
    {
        public string UsersInput { get; set; }

        public virtual string Manipulate(string input)
        {
            return string.Empty;
        }
    }
}
