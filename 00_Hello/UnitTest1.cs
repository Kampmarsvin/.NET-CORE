
using Xunit;

namespace _00_Hello
{
    public class UnitTest1
    {
        [Fact]
        public void TestHello() {
            Assert.Equal("Hello", Functions.Hello());
        }

         [Fact]
        public void TestHelloFred() {
            Assert.Equal("Hello, Fred", Functions.Hello("Fred"));
        }
    }
}
