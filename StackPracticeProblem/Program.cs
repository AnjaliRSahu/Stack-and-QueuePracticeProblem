using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack operations");
            StackOperations stackOperations=new StackOperations();
            Console.WriteLine();
            stackOperations.Push(70);
            stackOperations.Push(30);
            stackOperations.Push(56);


            Console.ReadLine();
        }
    }
}
