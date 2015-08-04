using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 装饰者模式.Beverage
{
    public abstract class Beverage
    {
        protected string description = "未知的咖啡种类";

        //得到咖啡的描述
        public virtual string getDescription()
        {
            return description;
        }
        //虚方法得到金额（花费）
        public abstract double Cost();
    }
}
