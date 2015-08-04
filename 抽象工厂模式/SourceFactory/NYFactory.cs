using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 抽象工厂模式.Source;

namespace 抽象工厂模式.SourceFactory
{
    /// <summary>
    /// 纽约原料工厂
    /// </summary>
    public class NYFactory :ISourceFactory
    {
        public Source.Cabbage CreateCabbage()
        {
            return new NYCabbage();
        }

        public Source.Jam CreateJam()
        {
            return new NYJam();
        }

        public Source.Beef CreateBeef()
        {
            return new NYBeef();
        }

        public Source.Nuts CreateNuts()
        {
            return new NYNuts();
        }
    }
}
