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
            Console.WriteLine("Welcome to Stack and Queue");
            Console.WriteLine("Data Structure");
            Console.WriteLine("\n1.Stack\n2.Stack Using linked List");
            Console.WriteLine("\nEnter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>(); //creating a object of Stack generic class 
            switch (ch)
            {
                case 1:
                    stack.Push(70);// Calling method of Stack generic class to push 70 element in stack
                    stack.Push(30);// Calling method of Stack generic class to push 30 element in stack
                    stack.Push(56);// Calling method of Stack generic class to push 56 element in stack
                    stack.Display(); // Calling method of Stack generic class to display all element in stack
                    stack.Display(); // Calling method of Stack generic class to display all element in stack
                    break;
                case 2:
                    stack.PushByLinkedList(70); // Calling method of Stack generic class to push 70 element in stack
                    stack.PushByLinkedList(30); // Calling method of Stack generic class to push 70 element in stack
                    stack.PushByLinkedList(56); // Calling method of Stack generic class to push 70 element in stack
                    stack.DisplayByLinkedList(); // Calling method of Stack generic class to display all element in stack
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;

            }
            Console.ReadLine();
        }
    }
}
