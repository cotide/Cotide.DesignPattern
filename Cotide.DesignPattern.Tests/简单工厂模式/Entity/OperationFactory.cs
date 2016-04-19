using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.简单工厂模式.Entity
{
    /// <summary>
    /// 运算工厂
    /// </summary>
    public  class OperationFactory
    {

        /// <summary>
        /// 创建运算类
        /// </summary>
        /// <param name="operate">操作符</param>
        /// <returns></returns>
        public static Operation CreateOperate(string operate)
        {
            
            switch (operate)
            {
                case "+":
                    return  new OperationAdd();
                case "-":
                    return new OperationSub();
                case "*":
                    return new OperationMul();
                case "/":
                    return new OperationDiv();

            }
            throw new Exception("提供操作符有误");
        }
    }
}
