using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class RocketFly:IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("我会火箭飞行");
        }
    }
}
