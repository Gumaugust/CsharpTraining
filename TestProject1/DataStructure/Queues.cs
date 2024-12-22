using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.DataStructure
{
    public interface Queues<T>
    {
        void Enqueue(T item);

        T Dequeue();

        bool Contains(T item);

        void Clear();
        
        public int Capacity();

        //void pushMany(T item);
    }
}
    