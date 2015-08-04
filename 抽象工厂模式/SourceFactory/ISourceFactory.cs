using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 抽象工厂模式.Source;

namespace 抽象工厂模式.SourceFactory
{
   public interface ISourceFactory
    {
       /// <summary>
       /// 创建大白菜
       /// </summary>
       /// <returns></returns>
       Cabbage CreateCabbage();
       /// <summary>
       /// 创建酱料
       /// </summary>
       /// <returns></returns>
       Jam CreateJam();
       /// <summary>
       /// 创建牛肉
       /// </summary>
       /// <returns></returns>
       Beef CreateBeef();
       /// <summary>
       /// 创建芝麻料
       /// </summary>
       /// <returns></returns>
       Nuts CreateNuts();

    }
}
