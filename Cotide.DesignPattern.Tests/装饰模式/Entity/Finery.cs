using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cotide.DesignPattern.Tests.装饰模式.Entity
{
    /// <summary>
    /// 服饰
    /// </summary>
    public class Finery : Person
    { 
        protected Person Person;
         
        public void Decorate(Person person)
        {
            this.Person = person;
        }

        public override void Show()
        {
            if (Person != null)
            {
                Person.Show();
            } 
        } 
    }
} 
