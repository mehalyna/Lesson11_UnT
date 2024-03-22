using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11_UnT
{
    public class Calculator
    {
        public int Add(int a, int b) 
        { 
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Devision(int a, int b)
        {
            if (b == 0) return 0;
            else return a / b;
        }
    }
}
