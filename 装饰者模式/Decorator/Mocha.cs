using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.Decorator
{
    /// <summary>
    /// 调料  摩卡
    /// </summary>
    public class Mocha :CondimentDecorator
    {
        Beverage.Beverage beverage;
       /// <summary>
       /// 构造函数，传入要装饰的对象
       /// </summary>
       /// <param name="beverage"></param>
        public Mocha(Beverage.Beverage beverage)
       {
           this.beverage = beverage;
       }

        //重写描述方法 某种咖啡 + Mocha
        public override string getDescription()
        {
            return beverage.getDescription() + ",Mocha";
        }

       //返回摩卡的价格
        public override double Cost()
        {
            return 3.60 + beverage.Cost();
        }
    }
}
