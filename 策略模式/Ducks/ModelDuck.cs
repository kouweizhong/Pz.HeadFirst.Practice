using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式.Ducks
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new CantFly();
            _quarkBehavior = new CantQuark();
        }

        public override void display()
        {
            Console.WriteLine("我是一只模型鸭子，我不会飞，不会叫");
        }
    }
}
