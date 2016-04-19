using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.装饰模式.Entity
{
    /// <summary>
    /// 人
    /// </summary>
    public class Person
    {


        /// <summary>
        /// 人名
        /// </summary>
        private readonly string _name;

        public Person()
        {
            
        }


        public Person(string name)
        {
            this._name = name;
        }

        /// <summary>
        /// 行为
        /// </summary>
        public virtual void Show()
        {
            Console.WriteLine("装扮的{0}",_name);
        }
    }
}
