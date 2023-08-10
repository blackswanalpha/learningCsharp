using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolfees
{
    class Program
    {
        static void Main(string[] args)
        {
            float P, T;
            T = 1;
            float R, SI;
            Console.Write("Enter Amount :");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate :");
            R = Convert.ToSingle(Console.ReadLine());
            SI = 0;
            
            


            while (SI >= (2*P))
            {
                T = T + 1;
                SI = (P * R)+ P ;
                P = SI;
            Console.WriteLine("Simple Interest is :"+ SI);

            }

            Console.ReadKey();
        }
    }
}
