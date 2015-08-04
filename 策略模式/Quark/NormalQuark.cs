using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 普通叫
    /// </summary>
    public class NormalQuark:IQuarkBehavior
    {
        public void Quark()
        {
            Console.WriteLine("我会正常鸣叫");
        }
    }
}
