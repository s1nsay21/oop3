﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Oop.o.tichshenkooop.assignment1
{
    public class GrayPrinter : ColorPrinter{
     
        public override void printInColor(string value)
        {
            Console.WriteLine(value + " this is " + value.GetType().Name,
               Console.ForegroundColor = ConsoleColor.Gray);
        }
    }
}
