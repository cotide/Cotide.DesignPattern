using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Cotide.DesignPattern.Tests.装饰模式.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cotide.DesignPattern.Tests.装饰模式
{
    
    /// <summary>
    /// 装饰模式
    /// </summary>
    [TestClass]
    public class DecorativePatternTest
    {
        

        [TestMethod]
        public void Run()
        {
            // 人物
            Person person = new Person("李小妹");
          
            // 装饰内容
            Tshirts tshirts = new Tshirts();
            BigTrouser bigTrouser = new BigTrouser();

            // 装饰
            tshirts.Decorate(person);
            bigTrouser.Decorate(tshirts);

            // 显示
            bigTrouser.Show();

        }
    }
}
