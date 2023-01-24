using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Stack
    {
        Node top;
        public Stack()//constructor
        {
            this.top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if (top == null)
            {
                node.Next = null;
            }
            else
            {
                node.Next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack", data);
        }

        public void display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.Next;
            }
            if (top == null)
            {
                Console.WriteLine("Stack Empty");
            }
        }
        public void Peek()//This method returns the object at the beginning of the stack without removing it.
        {

            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("{0} is in the top of stack", top.data);
            }
        }
        public void Pop()//This method returns the object at the beginning of the
                         //stack with modification means this method removes the topmost element of the stack.
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty deletion is not possible");
            }
            else
            {
                Console.WriteLine("Values popped is {0} ", top.data);
                top = top.Next;
            }
        }
    }
}
