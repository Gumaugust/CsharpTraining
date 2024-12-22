using System;

using TestProject1.DataStructure;

namespace TestProject1.xUnitTest
{
    public class StackUnitTest
    {
       
        [Fact]
        public void TestStack()
        {
            int n = 100;
            Stacks<int> st = new Stacks<int>(n);

            st.Push(1);
            st.Push(2);
            Assert.Equal(2, st.size());
            st.Push(3);
            Assert.Equal(3, st.size());

            ///  1 2 3 =pop>  1 2 
            st.Pop();
            Assert.Equal(2,st.size());
            
            Assert.Equal(2, st.Pop());
        }
    }
}
