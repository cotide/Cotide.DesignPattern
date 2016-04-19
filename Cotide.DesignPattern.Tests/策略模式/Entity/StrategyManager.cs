using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.策略模式.Entity
{
    /// <summary>
    /// 策略管理对象
    /// </summary>
    public class StrategyManager
    {
        /// <summary>
        /// 算法
        /// </summary>
        private readonly Strategy _strategy;

        public StrategyManager(Strategy strategy)
        {
            this._strategy = strategy;
        }
 
        /// <summary>
        /// 输出当前算法
        /// </summary>
        public void AlgorithmInterface()
        {
            _strategy.AlgorithmInterface();
        }
    }
}
