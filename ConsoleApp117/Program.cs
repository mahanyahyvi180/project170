using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp117
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional AND (&&)");
            Console.WriteLine($"false && false:{false && false}");
            Console.WriteLine($"false && true:{false && true}");
            Console.WriteLine($"true &&false:{true && false}");
            Console.WriteLine($"true&&true:{true && true}\n");


            Console.WriteLine("Conditional OR (||)");
            Console.WriteLine($"false || false:{false || false}");
            Console.WriteLine($"false || true:{false || true}");
            Console.WriteLine($"true ||false:{true || false}");
            Console.WriteLine($"true||true:{true || true}\n");


            Console.WriteLine("Boolean logical AND (&)");
            Console.WriteLine($"false & false:{false & false}");
            Console.WriteLine($"false & true:{false & true}");
            Console.WriteLine($"true & false:{true & false}");
            Console.WriteLine($"true & true:{true & true}\n");

            Console.WriteLine("Boolean logical inclusive OR(|)");
            Console.WriteLine($"false | false:{false | false}");
            Console.WriteLine($"false | true:{false | true}");
            Console.WriteLine($"true | false:{true | false}");
            Console.WriteLine($"true | true:{true | true}\n");


            Console.WriteLine("Boolean logical exclusive OR(^)");
            Console.WriteLine($"false ^ false:{false ^ false}");
            Console.WriteLine($"false ^ true:{false ^ true}");
            Console.WriteLine($"true ^ false:{true ^ false}");
            Console.WriteLine($"true ^ true:{true ^ true}\n");

            Console.WriteLine("Logical negation (!)");
            Console.WriteLine($"!false:{!false}");
            Console.WriteLine($"!true:{!true}");
            Console.ReadLine();
        }
    }
}
