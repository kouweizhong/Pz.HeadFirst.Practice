using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.Decorator
{
    /// <summary>
    /// 调料  牛奶
    /// </summary>
    public class Milk :CondimentDecorator
    {
        Beverage.Beverage beverage;
       /// <summary>
       /// 构造函数，传入要装饰的对象
       /// </summary>
       /// <param name="beverage"></param>
        public Milk(Beverage.Beverage beverage)
       {
           this.beverage = beverage;
       }

        //重写描述方法 某种咖啡 + Milk
        public override string getDescription()
        {
            return beverage.getDescription() + ",Milk";
        }

       //返回摩卡的价格
        public override double Cost()
        {
            return 2.00 + beverage.Cost();
        }
    }
}
