using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    internal class Queue
    {
        Node rear;
        Node front;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (front == null)
            {
                rear = node;
                front = node;
            }
            else
            {
                rear.Next = node;
                rear = rear.Next;
            }

        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is Empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine("|" + temp.data + "|");
                temp = temp.Next;
            }
        }
    }
}