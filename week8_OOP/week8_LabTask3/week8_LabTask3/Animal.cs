﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week8_LabTask3
{
    class Animal
    {
        protected string name;
        public Animal(string name)
        {
            this.name = name;
        }

        public virtual string toString()
        {
            return "Animal ["+ " Name = " + name +"]";
        }

        public virtual void Greets()
        {

        }
    }
}
