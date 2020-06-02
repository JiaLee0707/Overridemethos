using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Overridemethos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Power(2));
            Console.WriteLine(Program.Power(2, 3));
            Console.WriteLine(Program.SumAll(5));
            Console.WriteLine(Program.SumAll(0, 5));

        }

        public static int Power(int input)
        {
            return input*=input;
        }
        public static int Power(int input, int count)
        {
            int power = input;
            for(int i=0; i<count-1; i++)
            {
                power = power * input;
            }
            return power;
        }

        public static int SumAll(int end)
        {
            int sum = 0;
            for(int i=0; i<end; i++)
            {
                sum += i;
            }

            return sum;
        }
        public static int SumAll(int start, int end)
        {
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
