using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Cotide.DesignPattern.Tests.简单工厂模式.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cotide.DesignPattern.Tests.简单工厂模式
{ 
    /// <summary>
    /// 简单工厂模式
    /// </summary>
    [TestClass]
    public class SimpleFactoryTest
    { 

        [TestMethod]
        public void Run()
        {
            var oper = OperationFactory.CreateOperate("*");
            oper.NumberA = 1;
            oper.NumberB = 2;
            Console.WriteLine(oper.GetResult());  
        }
    }
}
