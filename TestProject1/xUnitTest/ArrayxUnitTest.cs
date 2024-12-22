using Xunit.Sdk;
using System.Collections;
using TestProject1.DataStructure;
namespace TestProject1.xUnitTest
{

    public class UnitTest1
    {
        public Arrays<string> alt;

        [Fact]
        public void TestArray()
        {
            alt = new Arrays<string>(5);

            alt.Add("A");
            alt.Add("Balance");
            alt.Add("Cryst");
            alt.Add("Dr");
            alt.Add("E");

            int posApple = alt.FindPos("A");
            Assert.Equal(0, posApple);

            Assert.Equal("Balance", alt.Get(1));
            // size = 5
            Assert.Equal(5, alt.Size());

            string[] blt = new string[] { "1" };
            alt.AddAll(blt);

            // size = 5 + 1 = 6
            Assert.Equal(6, alt.Size());

            // size = 6-1 = 5
            alt.Remove("E");
            Assert.NotEqual(6, alt.Size());
            Assert.Equal(alt.Size(), blt.Length + 4);

            //size = 5-1 = 4
            alt.RemoveAt(3);
            Assert.Equal("1", alt.Get(3));

            alt.Set(3, "newSet");
            Assert.Equal("newSet", alt.Get(3));

            alt.Clear();
            Assert.Equal(0, alt.Size());

        }
        [Fact]
        public void TestFindPos()
        {
            alt = new Arrays<string>(5);
            alt.Add("A");
            int posApple = alt.FindPos("A");
            Assert.Equal(0, posApple);
            Assert.Equal(-1, alt.FindPos("B"));
        }

        [Fact]
        public void TestToString()
        {
            alt = new Arrays<string>(2);
            string exp = "[]";
            Assert.Equal(exp, alt.ToString());

            string[] arr = new string[] { "A", "B" };
            alt.AddAll(arr);
            string epx = "[A,B]";
            Assert.Equal(epx, alt.ToString());
        }
    }
}