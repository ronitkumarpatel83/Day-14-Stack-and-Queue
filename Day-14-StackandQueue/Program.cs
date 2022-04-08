using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue Program");
            Console.WriteLine("Data Structure");
            Console.WriteLine("\n1.Stack\n2.Stack Using linked List\n3.Queue Using LinkedList");
            Console.WriteLine("\nEnter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>(); //creating a object of Stack generic class 
            Queue<int> queue = new Queue<int>(); //creating a object of Queue generic class 
            switch (ch)
            {
                case 1:
                    stack.Push(70);// Calling method of Stack generic class to push 70 element in stack
                    stack.Push(30);// Calling method of Stack generic class to push 30 element in stack
                    stack.Push(56);// Calling method of Stack generic class to push 56 element in stack
                    stack.Display(); // Calling method of Stack generic class to display all element in stack
                    stack.Display(); // Calling method of Stack generic class to display all element in stack
                    stack.Peek(); // Calling method of Stack generic class to peek top most element of stack
                    stack.Pop(); // Calling method of Stack generic class to delete top most element of stack
                    Console.WriteLine("\nIs stack empty :: " + stack.isEmpty());
                    break;
                case 2:
                    stack.PushByLinkedList(70); // Calling method of Stack generic class to push 70 element in stack
                    stack.PushByLinkedList(30); // Calling method of Stack generic class to push 70 element in stack
                    stack.PushByLinkedList(56); // Calling method of Stack generic class to push 70 element in stack
                    stack.DisplayByLinkedList(); // Calling method of Stack generic class to display all element in stack
                    break;
                case 3:
                    queue.Enqueue(56); // Calling method of Queue generic class to enqueue 56 element in Queue
                    queue.Enqueue(30); // Calling method of Queue generic class to enqueue 56 element in Queue
                    queue.Enqueue(70); // Calling method of Queue generic class to enqueue 56 element in Queue
                    queue.Display(); // Calling method of Queue generic class to display all element in Queue                    
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
