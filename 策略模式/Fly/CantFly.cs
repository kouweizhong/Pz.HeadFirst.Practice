using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class CantFly:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("我不会飞行");
        }
    }
}
