using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternPerson
{
    class Finery:Person
    {
        protected Person person;

        //打扮
        public void Decorate(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person!=null)
            {
                person.Show();
            }
        }
    }
}
