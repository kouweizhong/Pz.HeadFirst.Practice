using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式.Pizza
{
   public class DCPizza:Pizza
    {
        public override void Prapare()
        {
            throw new NotImplementedException();
        }
    }
}
