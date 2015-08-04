using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.Coffee
{
    /// <summary>
    /// 拿铁咖啡
    /// </summary>
    public class NaTie : Beverage.Beverage
    {

        public NaTie()
        {
            description = "NaTie ";
        }
        public override double Cost()
        {
            return 10.00;
        }
    }
}
