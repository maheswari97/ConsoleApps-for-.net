using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program2
    {
        //public static void Main(string[] Args)
        //{
        //    sample s1 = new sample();
        //   Console.WriteLine( s1.pointResult(1, 1));

        //}
    }

    public class sample
    {
       public int pointResult(int twopointers, int threepointers)
        {

            int Res = 0;
            Res = twopointers * 2 + threepointers * 3;
            
            return Res;
        }
    }
}
