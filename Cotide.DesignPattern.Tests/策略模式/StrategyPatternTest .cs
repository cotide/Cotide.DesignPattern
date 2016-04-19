using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Cotide.DesignPattern.Tests.策略模式.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cotide.DesignPattern.Tests.策略模式
{
     
    [TestClass]
    public class StrategyPatternTest
    {
         
        [TestMethod]
        public void Run()
        {
            StrategyManager strategyManager =new StrategyManager(new StrategyA());
            strategyManager.AlgorithmInterface(); 
        }
    }
}
