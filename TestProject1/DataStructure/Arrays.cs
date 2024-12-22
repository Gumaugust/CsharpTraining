using System;

using System.Text;


namespace TestProject1.DataStructure
{
    public class Arrays<T> : Ilist<T>
    {
        private T[] array;
        private int currPos;

        public Arrays(int capacity)
        {
            if (capacity < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            array = new T[capacity];
            currPos = 0;

        }

        public int Size()
        {
            return currPos;
        }

        private void CheckFull()
        {
            if (currPos == array.Length)
            {
                T[] newArray = new T[array.Length * 3 / 2 + 1];
                Array.Copy(array, 0, newArray, 0, array.Length);
                array = newArray;
            }
        }
        public void Add(T obj)
        {
            CheckFull();
            array[currPos] = obj;
            currPos++;
        }

        public void AddAll(T[] array)
        {
            foreach (T i in array)
            {
                Add(i);
            }
        }
        public void Clear()
        {
            for (int i = 0; i < currPos; i++)
            {
                array[i] = default;
            }
            currPos = 0;
        }

        public int FindPos(T obj)
        {
            for (int Pos = 0; Pos < currPos; Pos++)
            {
                if (array[Pos] != null && array[Pos].Equals(obj))
                {
                    return Pos;
                }

            }
            return -1;
        }

        public T Get(int pos)
        {
            return array[pos];
        }

        public bool Remove(T obj)
        {
            int pos = FindPos(obj);
            RemoveAt(pos);

            return true;
        }

        public T RemoveAt(int pos)
        {
            if (pos > currPos || pos < 0)
            {
                throw new IndexOutOfRangeException(" -- out of range array --");
            }
            while (pos < currPos)
            {
                array[pos] = array[pos + 1];
                pos++;
            }
            currPos--;
            return array[pos];
        }

        public void Set(int pos, T obj)
        {
            array[pos] = obj;
        }

        public string ToString()
        {

            if (Size() == 0) return "[]";
            else
            {
                StringBuilder sb = new StringBuilder(currPos);
                sb.Append("[");

                //last element will not has "," so just use currPos -1
                for (int i = 0; i < currPos - 1; i++)
                {
                    sb.Append(array[i]).Append(",");
                }
                sb.Append(array[currPos - 1]).Append("]");
                return sb.ToString();
            }

        }
    }
}
