﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablesforloop
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.Write("\n");
            }

            Console.ReadLine();
        }
    }
}
