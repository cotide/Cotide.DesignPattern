using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.策略模式.Entity
{
    /// <summary>
    /// 抽象算法类
    /// </summary>
    public  abstract  class Strategy
    {
        /// <summary>
        /// 输出当前算法
        /// </summary>
        public abstract void AlgorithmInterface();
    }
}
