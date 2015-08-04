using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 抽象工厂模式.Source;

namespace 抽象工厂模式.SourceFactory
{
    /// <summary>
    /// 赌城原料工厂
    /// </summary>
    public class DCFactory : ISourceFactory
    {
        public Source.Cabbage CreateCabbage()
        {
            return new DCCabbage();
        }

        public Source.Jam CreateJam()
        {
            return new DCJam();
        }

        public Source.Beef CreateBeef()
        {
            return new DCBeef();
        }

        public Source.Nuts CreateNuts()
        {
            return new DCNuts();
        }
    }
}
