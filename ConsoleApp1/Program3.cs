using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program3
    {
        //public static void Main(string[] args)
        //{
        //    Elder el= new Elder();
        //  Console.WriteLine(  el.Sec(28827050410L, 35165045587L, 7109602, 13719506));
        //}
    }


  public  class Elder
    {
        public long Sec(long n,long m,long k, long newp)
        {
            long res = 0;
            long[,] elderSeconds=new long[m,n];

            for(int i = 0; i < m;i++)
            {
                for(int j = 0; j < n; j++)
                {
                    elderSeconds[i, j] = i ^ j;
                    elderSeconds[i, j]=   elderSeconds[i, j] > k? elderSeconds[i, j] - k : 0;
                    res =  res + elderSeconds[i,j];
                    
                }
            }
            while (res > newp-1)
            {
                res =  res - newp;
            }
            
            return res;
        }
    }
}
