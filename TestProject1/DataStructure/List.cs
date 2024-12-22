using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.DataStructure
{
    public interface Ilist<T>
    {
        int Size(); //
        void Clear(); //
        void Add(T obj); //
        void AddAll(T[] obj); //
        bool Remove(T obj); //
        T RemoveAt(int pos); //
        T Get(int pos);
        void Set(int pos, T obj);
        int FindPos(T obj); //
        string ToString();
    }

}
