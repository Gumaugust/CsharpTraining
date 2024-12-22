using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.DataStructure
{
    public class Stacks<T>
    {
        private int peek = 0;
        private T[] values;

        public Stacks(int size = 100) { values = new T[size]; }

        public void Push(T item)
        {
            if (peek > values.Length) { throw new InvalidOperationException(" (push) out of Stack"); }
            values[peek++] = item;
        }

        public T Pop()
        {
            if (peek == 0)
            {
                throw new InvalidOperationException();
            }
            return values[--peek];
        }
        public int size()
            { return peek; }


    }
}
