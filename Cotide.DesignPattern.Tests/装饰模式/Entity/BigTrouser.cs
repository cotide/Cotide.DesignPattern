using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.装饰模式.Entity
{
    public class BigTrouser : Finery
    {

        public override void Show()
        {
            Console.WriteLine("垮裤");
            base.Show();
        }
    }
}
