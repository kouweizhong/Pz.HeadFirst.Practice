using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式.Source
{
    /// <summary>
    /// 纽约的原料
    /// </summary>
    public class NYJam : Jam
    {
        public override string GetName()
        {
            return "纽约：" + base.GetName();
        }
    }

    public class NYCabbage : Cabbage
    {
        public override string GetName()
        {
            return "纽约：" + base.GetName();
        }
    }
    public class NYBeef : Beef
    {
        public override string GetName()
        {
            return "纽约：" + base.GetName();
        }
    }
    public class NYNuts : Nuts
    {
        public override string GetName()
        {
            return "纽约：" + base.GetName();
        }
    }
}
