﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.StepanovNV.Sprint0.Task2.V0.lib;
namespace Tyuiu.StepanovNV.Sprint0.Task2.V0
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Игорь"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}