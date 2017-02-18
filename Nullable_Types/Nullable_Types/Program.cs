using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(int?); //???????

            int? x = 3;
            bool? y = true;
            
            Type t1 = x.GetType();
            Type t2 = y.GetType();

            Console.WriteLine(t1.FullName); //"System.Int32" 
            Console.WriteLine(t1.Name);//Int32
            Console.WriteLine(t2.Name);

            
            //if (type.IsGenericType
            //    && type.GetGenericTypeDefinition() == typeof(Nullable<>))
            //{ Console.WriteLine(true); }   //???????

            Console.ReadKey(); 

        }
    }
}
