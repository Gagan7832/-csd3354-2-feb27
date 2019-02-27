using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace feb27
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor();
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
            OrderProcessor.Process();
        }
    }
}
