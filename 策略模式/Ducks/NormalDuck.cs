using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.Ducks
{
    public class NormalDuck : Duck
    {
        public NormalDuck()
        {
            _flyBehavior = new NormalFly();
            _quarkBehavior = new NormalQuark();
        }

        public override void display()
        {
            Console.WriteLine("我是一只正常的鸭子，我可以正常鸣叫和飞行");
        }
    }
}
