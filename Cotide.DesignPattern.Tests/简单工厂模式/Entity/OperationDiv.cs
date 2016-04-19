using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.简单工厂模式.Entity
{
    /// <summary>
    /// 除法运算
    /// </summary>
    public  class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            return NumberA / NumberB;
        }
    }
}
