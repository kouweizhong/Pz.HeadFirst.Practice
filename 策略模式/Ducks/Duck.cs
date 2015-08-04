using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    /// <summary>
    /// 鸭子类
    /// </summary>
    public abstract class Duck
    {
        /// <summary>
        /// 飞行接口
        /// </summary>
        protected IFlyBehavior _flyBehavior;
        /// <summary>
        /// 鸭子叫接口
        /// </summary>
        protected IQuarkBehavior _quarkBehavior;

        //构造函数，默认
        public Duck() { }

        //构造函数传入某种鸭子
        public Duck(IFlyBehavior fly, IQuarkBehavior quark)
        {
            this._flyBehavior = fly;
            this._quarkBehavior = quark;
        }

        /// <summary>
        /// 鸭子飞行 将飞行业务拆开
        /// </summary>
        public void peformFly()
        {
            _flyBehavior.fly();
        }
        /// <summary>
        /// 鸭子叫 将鸣叫业务拆开
        /// </summary>
        public void performQuark()
        {
            _quarkBehavior.Quark();
        }

        /// <summary>
        /// 抽象方法，鸭子的外观
        /// </summary>
        public abstract void display();
    }
}
