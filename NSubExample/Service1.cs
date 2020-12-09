using System;

namespace NSubExample
{
    public interface IService1
    {
        int MultiplyByTwo(int i);
    }
    public class Service1 : IService1
    {
        public int MultiplyByTwo(int i)
        {
            return i*2;
        }
    }
}
