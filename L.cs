using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=5;i++)
            {
                for(int j=1;j<=5;j++)
                {
                    if(i<=5&&j==1||i==5&&j<=3)
                    {
                    Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ") ;
                    }
                }
                
                Console.WriteLine();
            }
           
            Console.ReadLine();
        }
    }
}
