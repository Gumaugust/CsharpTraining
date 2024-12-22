using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.DataStructure
{
    public class SimpleQueues<T> : Queues<T>
    {
        private int pointer;
        private T[] values;


        /*     T Enqueue();

                T Dequeue();

                void Contains(T item);

                void Clear();*/

        public SimpleQueues(int size = 100)
        {
            pointer = 0;
            values = new T[size];

        }
        // EnQueue: get first value but not delete it  
        public void Enqueue(T item)
        {
            if (pointer < 0 || pointer >= values.Length)
            {
                throw new InvalidOperationException("PUSH method: out of range pointer");
            }
            else
            {
                values[pointer++] = item;
            }
        }
        // Dequeue: get first value and Delete it 
        public T Dequeue()
        {
            if (pointer == 0)
            {
                throw new InvalidOperationException("POP: pointer = 0");
            }
            T storeValues = values[0];
            for (int index = 0; index < pointer - 1; index++)
            {
                values[index] = values[index + 1];
                // d c b a
                // 3 2 1 0 
            }
            values[pointer - 1] = default(T);
            pointer--;

            return storeValues;
        }

        public bool Contains(T item)
        {
            if (item == null) { return false; }

            for (int i = 0; i < pointer; i++)
            {
                if (values[i].Equals(item))
                {
                    return true; // Item found in the queue
                }
            }
            return false;
        }
        public void Clear()
        {
            while (pointer > 0)
            {
                values[pointer] = default(T);
                pointer--;
            }
        }
        public int Capacity() { return pointer; }

    }
}
