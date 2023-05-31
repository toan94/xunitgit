using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataverse
{
    public class Service1 : IService1
    {
        public bool b { get; set; }
        public Service1()
        {
            b = false;
        }

    }
}
