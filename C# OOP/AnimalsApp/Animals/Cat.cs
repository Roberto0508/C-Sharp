﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cat: Animal
    {
        public Cat(string name, string favouriteFood)
        {
        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "MEOOW";
        }
    }
}
