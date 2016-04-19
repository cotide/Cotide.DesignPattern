using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.简单工厂模式.Entity
{
    /// <summary>
    /// 乘法运算
    /// </summary>
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA  *  NumberB;
        }
    }
}
