using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_StackandQueue
{
    internal class Queue<T>
    {
        CustomLinkedList<T> list = new CustomLinkedList<T>(); // Creating object of Linked List generic class
        private Node<T> top; // Creating variable to maintain Top of queue
        public void Enqueue(T data) // creating a method to add Element in queue using Linked List
        {
            list.Append(data); // Calling append method of linked list to add element
            Console.WriteLine($"\n{data} is inserted in Queue");
        }
        public void Display()// creating a method to Display Element in queue using Linked List
        {
            this.top = list.top; // Storing Linked list head to top variable
            int count = 0;
            Node<T> temp = this.top; // taking top as temp node
            if (temp == null) // If top is null that means linked list is empty
            {
                Console.WriteLine("\nThe Queue is Empty");
                return;
            }
            Console.WriteLine("\nAll the element of queue from bottom to top are : ");
            while (temp != null) // If top is not null then print one by one element of queue
            {
                Console.WriteLine(temp.data + " ");
                count++;
                temp = temp.next; // Go to next node
            }
            Console.WriteLine($"Size of Queue is : {count}");
        }
        public void Dequeue() // creating a method to Dequeue all Element in queue using Linked List
        {
            this.top = list.top; // Storing Linked list head to top variable
            while (this.top != null) // If top is not null then print one by one element of queue
            {
                Console.WriteLine($"\nNow deleting first element of queue {top.data} ....");
                list.DeleteAtFirst(); // Calling method og Linked list class to dequeue first element
                Display();
                this.top = list.top;
            }
        }
    }
}
