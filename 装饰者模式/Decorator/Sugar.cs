using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 装饰者模式.Beverage;

namespace 装饰者模式.Decorator
{
    /// <summary>
    /// 调料 糖
    /// </summary>
   public class Sugar :CondimentDecorator
    {
       Beverage.Beverage beverage;
       /// <summary>
       /// 构造函数，传入要装饰的对象
       /// </summary>
       /// <param name="beverage"></param>
       public Sugar(Beverage.Beverage beverage)
       {
           this.beverage = beverage;
       }
       
       //重写描述方法 某种咖啡 + Sugar
        public override string getDescription()
        {
            return beverage.getDescription() + ",Sugar";
        }

       //返回糖的价格
        public override double Cost()
        {
            return 2.50 + beverage.Cost();
        }
    }
}
