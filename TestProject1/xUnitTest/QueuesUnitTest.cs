using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.DataStructure;

namespace TestProject1.xUnitTest
{
    
    public class QueuesUnitTest
    {
        [Fact]
        public void TestQueue()
        {
         SimpleQueues<int> ds = new SimpleQueues<int>(20); 
            ds.Enqueue(1);
            ds.Enqueue(2);
            ds.Enqueue(3);
            ds.Enqueue(4);
            Assert.Equal(4, ds.Capacity());
            Assert.Equal(1, ds.Dequeue());
            ds.Dequeue();
            Assert.Equal(2, ds.Capacity());
            // 3 4 
            Assert.False( ds.Contains(1));
            Assert.True( ds.Contains(3));
        }

    }
}
