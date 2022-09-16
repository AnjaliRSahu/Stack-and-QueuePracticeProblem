using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPracticeProblem
{
    public class QueueOperations
    {
        Node front;
        Node rear;
        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear == null)
            { 
                rear= newNode;
                front = rear;
            }
            else
            {
                rear.next= newNode;
                rear= newNode;
            }

        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            while (front != null)
            {
                Console.WriteLine(front.data);
            }
        }
        public void Dequeue()
        {
            if (front == null)
            { 
               Console.WriteLine("Empty");
            }
            Console.WriteLine("{0} is deleted from the queue", front.data);
            front=front.next;
        }
    }
}
