using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPracticeProblem
{
    public class StackOperations
    {
        Node top;
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                //Console.WriteLine("Stack is empty");
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top= newNode;
            Console.WriteLine("{0} is pushed to stack and ",data);
 }
    }
}
