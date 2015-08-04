using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 不能叫
    /// </summary>
    public class CantQuark:IQuarkBehavior
    {
        public void Quark()
        {
            Console.WriteLine("我不会叫");
        }
    }
}
