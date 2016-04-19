using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.策略模式.Entity
{ 
    public class StrategyC :Strategy
    {
        /// <summary>
        /// 算法C
        /// </summary>
        public override void AlgorithmInterface()
        {
            Console.WriteLine("实现算法C");
        }
    }
}
