using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class Problem
    {
        static void Main(string[] args)
        {
            /*  Stack st = new Stack();
              st.Push(70);
              st.Push(30);
              st.Push(56);
              st.display();
              st.Peek();
              st.Pop();
              st.display();
              st.Peek();
              st.Pop();
              st.display();
              st.Peek();
              st.Pop();
              st.display();*/
            Queue qu = new Queue();
            qu.Enqueue(56);
            qu.Enqueue(30);
            qu.Enqueue(70);
            qu.Display();
        }
    }
}