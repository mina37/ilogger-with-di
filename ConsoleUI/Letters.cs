﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Letters : IProcessor
    {
        public bool Process(string s)
        {
            Console.WriteLine("Letters Processing");
            return true;
        }
    }
}
