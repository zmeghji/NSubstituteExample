using System;
using System.Collections.Generic;
using System.Text;

namespace NSubExample
{
    public class Service2
    {
        private readonly IService1 _service1;

        public Service2(IService1 service1)
        {
            _service1 = service1;
        }
        public int MultiplyByFour(int num)
        {
            return _service1.MultiplyByTwo(num) * 2;
        }
    }
}
