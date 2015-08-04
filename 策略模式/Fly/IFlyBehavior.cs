using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public interface IFlyBehavior
    {
        /// <summary>
        /// 飞行
        /// </summary>
        void fly();
    }
}
