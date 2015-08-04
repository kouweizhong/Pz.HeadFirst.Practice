using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 抽象工厂模式.Source;

namespace 抽象工厂模式.Pizza
{
    public abstract class PizzaStore
    {
        Jam jam;
        Nuts nuts;
        Beef beef;
        Cabbage cabbage;
        public abstract Pizza OrderPizza(string type);

        /// <summary>
        /// 配送披萨，逻辑封装内部，外部不允许改变
        /// </summary>
        public void SendPizza()
        {
            Cook();
            Source();
            Bake();
            Cut();
            Box();
        }

        #region pizza制作步骤

        void Cook()
        {
            Console.WriteLine("正在制作Pizza:煮料\n");
        }
        void Source()
        {
            Console.WriteLine("正在制作Pizza:添加调料\n");
        }
        void Bake()
        {
            Console.WriteLine("正在制作Pizza:进行烘烤\n");
        }
        void Cut()
        {
            Console.WriteLine("正在制作Pizza:切成几块\n");
        }
        void Box()
        {
            Console.WriteLine("正在制作Pizza:装盒准备配送\n");
        }
        #endregion
    }
}
