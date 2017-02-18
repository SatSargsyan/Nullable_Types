﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_types2
{
    class Program
    {
        static void Main(string[] args)
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;

            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);

            double? num4;
            num4 = num1 + num2;  
            Console.WriteLine(" Value of num4: {0}", num4); //num4 also null


            bool? enabled1 = null;
            Console.WriteLine(" Value of enabled: >{0}<", enabled1); //I write >< , because null we cann't see
                                  
            Console.ReadKey();
        }
    }
}
