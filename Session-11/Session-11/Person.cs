﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class Person
    {
        public Guid PersonID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(Guid id)
        {
            PersonID = Guid.NewGuid();
        }

        public Person(Guid id, string name,string surname)
        {
            PersonID= id;
            Name= name;
            Surname= surname;
        }

        public Person()
        {

        }
        //test
    }
    
}
