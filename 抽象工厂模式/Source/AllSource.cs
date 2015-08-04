using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式.Source
{
    /*
     所有pizza的原料，包括
     * 大白菜
     * 酱料
     * 牛肉
     * 芝麻
     * 如果要加其他的就在这里加
     */
    #region 原材料
    public class Source
    {
        protected string name = "未定义原料名称";

        public Source()
        { }
      
        public virtual string GetName()
        {
            return name;
        }
    }

    //原料详细
    
    /// <summary>
    /// 大白菜
    /// </summary>
    public class Cabbage :Source
    {
        public Cabbage()
        {
            name = "大白菜";
        }
    }

    /// <summary>
    /// 酱料
    /// </summary>
    public class Jam : Source
    {
        public Jam()
        {
            name = "酱料";
        }
    }

    /// <summary>
    /// 牛肉
    /// </summary>
    public class Beef : Source
    {
        public Beef()
        {
            name = "牛肉";
        }
    }

    /// <summary>
    /// 芝麻
    /// </summary>
    public class Nuts : Source
    {
        public Nuts()
        {
            name = "芝麻";
        }
    }

    #endregion

}
