﻿using System.Net.NetworkInformation;

namespace Tyuiu.StepanovNV.Sprint0.Task5.V0.Lib
{
    public class DataService
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        public static int Subtraction(int a, int b)
        {
            return (a - b);
        }
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
        public static double Division(int a, int b)
        {
            if (b == 0)
                return -1;
            else
            {
                return a / b;
            }
        }
    }
}
