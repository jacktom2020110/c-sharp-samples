using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型示例
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficTransport<int> tt = new TrafficTransport<int>();
            tt.Miles = 100;

        }
    }
}
