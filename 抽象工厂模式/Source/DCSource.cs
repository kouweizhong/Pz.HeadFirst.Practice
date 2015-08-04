using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式.Source
{
    /// <summary>
    /// 赌城的原料
    /// </summary>
    public class DCJam : Jam
    {
        public override string GetName()
        {
            return "赌城：" + base.GetName();
        }
    }

    public class DCCabbage : Cabbage
    {
        public override string GetName()
        {
            return "赌城：" + base.GetName();
        }
    }
    public class DCBeef : Beef
    {
        public override string GetName()
        {
            return "赌城：" + base.GetName();
        }
    }
    public class DCNuts : Nuts
    {
        public override string GetName()
        {
            return "赌城：" + base.GetName();
        }
    }
}
