using System;
namespace TestProject1.xUnitTest
{
    {
        private LinkedLists<int> lt;

        [Fact]
        public void TestList()
        {
            lt = new LinkedLists<int>();
            lt.Add(1);
            lt.Add(2);
            Assert.Equal(2, lt.Size());

            lt.Add(3);
            lt.Add(4); 
            Assert.Equal(1, lt.FindPos(2));

            int[] newList = new int[2] {5,6};
            lt.AddAll(newList);
            Assert.Equal(6, lt.Size());

            var removeNode = lt.RemoveAt(5);
            Assert.Equal(6, removeNode);

            lt.Remove(5);
            Assert.Equal(4, lt.Size());

            Assert.Equal(2, lt.Get(1));

            lt.Set(3, 7);
            Assert.Equal(7, lt.Get(3));

            lt.Clear();
            Assert.Equal(0, lt.Size());
          
        }

    }
}

