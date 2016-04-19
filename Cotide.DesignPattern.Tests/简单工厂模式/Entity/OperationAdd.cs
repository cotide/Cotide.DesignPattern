using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.简单工厂模式.Entity
{
    /// <summary>
    /// 加法运算类
    /// </summary>
    public class OperationAdd : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
}
