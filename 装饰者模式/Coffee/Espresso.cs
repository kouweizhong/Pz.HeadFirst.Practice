using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.Coffee
{
    /// <summary>
    /// Espresso 咖啡
    /// </summary>
    public class Espresso :Beverage.Beverage
    {
        public Espresso()
        {
            description = "Espresso ";
        }
        public override double Cost()
        {
            return 5.00;
        }
    }
}
