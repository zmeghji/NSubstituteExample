using NSubExample;
using NSubstitute;
using NUnit.Framework;

namespace Tests
{
    public class Service2Test
    {
        private Service2 service2;
        private IService1 service1;
        [SetUp]
        public void Setup()
        {
            service1 = Substitute.For<IService1>();
            service2 = new Service2(service1);
        }

        [Test]
        public void MultiplyOneByFour()
        {
            service1.MultiplyByTwo(Arg.Any<int>()).Returns(2);

            var result = service2.MultiplyByFour(1);
            Assert.AreEqual(result, 4);
        }
    }
}