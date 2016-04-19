using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.策略模式.Entity
{
    /// <summary>
    /// 算法B
    /// </summary>
    public  class StrategyB: Strategy
    {

       public override void AlgorithmInterface()
       {
            Console.WriteLine("实现算法B");
        }
    }
}
