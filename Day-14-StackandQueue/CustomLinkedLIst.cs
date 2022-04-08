using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_StackandQueue
{
    internal class CustomLinkedList<T>
    {
        public Node<T> head; // Creatind head if linked list
        public Node<T> top;
        public void AddFirst(T data) // creating generic method to Add element at first of linked list
        {
            Node<T> newNode = new Node<T>(data); // Creating a new node 
            if (this.head == null)
            {
                this.head = newNode; // If head pointing to null then hode is directly pointing to new node
                return;
            }
            newNode.next = this.head; // newnode pointing to where head is currently pointing
            this.head = newNode; // head is pointing to new node
            this.top = this.head;
        }
        public void Append(T data) // creating generic method to Add element at first of linked list
        {
            Node<T> newNode = new Node<T>(data); // Creating a new node 
            if (this.head == null)
            {
                this.head = newNode; // If head pointing to null then hode is directly pointing to new node               
                return;
            }
            else
            {
                Node<T> temp = this.head; // taking head as temp node
                while (temp.next != null) // Find a last node 
                {
                    temp = temp.next;// Go to next node till last nast node               
                }
                temp.next = newNode; // Add new Node at last
            }
            this.top = this.head;
        }
        public void DeleteAtFirst() // creating generic method to delete element at first of linked list
        {
            if (this.head == null) //Checking that list is empty or not
            {
                return;
            }
            Node<T> temp = this.head; // Creating a temp node having head reference

            this.head = this.head.next;  // Deleting a first node  
            this.top = this.head;
        }
    }
}
