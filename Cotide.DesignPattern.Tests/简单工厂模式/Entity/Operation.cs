using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.简单工厂模式.Entity
{
    /// <summary>
    /// 统计基类
    /// </summary>
    public abstract class Operation
    {
        /// <summary>
        /// 数值1
        /// </summary>
        public double NumberA { get; set; }

        /// <summary>
        /// 数值2
        /// </summary>
        public double NumberB { get; set; }


        /// <summary>
        /// 计算结果
        /// </summary> 
        /// <returns></returns>
        public virtual double GetResult()
        {
            return 0;
        }

    }
}
