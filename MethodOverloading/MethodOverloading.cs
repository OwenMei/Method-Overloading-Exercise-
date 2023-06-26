using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class MethodOverloading
    {
        public static int Add(int a, int b) 
        {
            return a + b;
        }

        public static double Add(double a, double b) 
        {
            return a + b; 
        }

        public static string Add(int a, int b, bool c) 
        {
            if (c) 
            {
                if(a+b == 1) 
                {
                    return $"{a + b} dollar";
                }
                else
                {
                    return $"{a + b} dollars";
                }
            }
            else 
            {
                return $"{a + b}";
            }
        }
    }
}
