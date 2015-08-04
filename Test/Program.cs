using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 策略模式;
using 策略模式.Ducks;

using 装饰者模式;
using 装饰者模式.Beverage;
using 装饰者模式.Coffee;
using 装饰者模式.Decorator;

using 抽象工厂模式.Source;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //策略模式
            Test1();
            //装饰着模式
            TestDecorate();

            Console.ReadKey();
        }

        #region 策略模式测试
        static void Test1()
        {
            Duck duckNormal = new NormalDuck();
            Duck duckModel = new ModelDuck();

            duckNormal.display();
            duckNormal.performQuark();
            duckNormal.peformFly();

            duckModel.display();
            duckModel.performQuark();
            duckModel.peformFly();

        }
        #endregion

        #region 装饰者模式测试
        public static void TestDecorate()
        {
            Console.WriteLine("\n\n\n--------------------测试装饰者模式--------------------");
            //客人点了一杯espresso
            Beverage espresso = new Espresso();
            //客人点了一杯拿铁
            Beverage natie = new NaTie();
            espresso = new Milk(espresso);//添加牛奶
            espresso = new Sugar(espresso);//添加糖

            var desEspresso = espresso.getDescription();
            var costEspresso = espresso.Cost();
            Console.WriteLine("{0}共花费了{1}元", desEspresso, costEspresso);

            natie = new Milk(natie);//加奶
            natie = new Milk(natie);//加奶
            natie = new Sugar(natie);//加糖
            natie = new Mocha(natie);//加摩卡

            var desNatie = natie.getDescription();
            var costNatie = natie.Cost();
            Console.WriteLine("{0}共花费了{1}元", desNatie, costNatie);
        }
        #endregion
    }

}
