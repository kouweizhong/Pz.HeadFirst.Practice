using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 大声叫
    /// </summary>
   public class LoudQuark:IQuarkBehavior
    {
        public void Quark()
        {
            Console.WriteLine("我会大声叫");
        }
    }
}
