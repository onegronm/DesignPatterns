﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterTurkeyDemo
{
    public class WildTurkey : Turkey
    {
        public void gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
        
        public void fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }
    }
}
