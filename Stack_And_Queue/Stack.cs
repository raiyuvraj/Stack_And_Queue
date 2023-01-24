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
        }
    }
}
