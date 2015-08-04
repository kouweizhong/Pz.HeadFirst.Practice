using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
   public interface IQuarkBehavior
    {
        /// <summary>
        /// 叫声
        /// </summary>
        void Quark();
    }
}
