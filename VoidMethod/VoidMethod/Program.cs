﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the method in the class, passing in two numbers.
            VoidMethod calculate = new VoidMethod();
            //call the method in the class, specifying the parameters by name.
            calculate.MultiplyNumber(int1: 2, int2: 4);
            Console.ReadLine();
        }
        
    }
}
