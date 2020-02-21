using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DecoratorPatternMain
    {
        static void Main1(string[] args)
        {
            ConcreteComponent c = new ConcreteComponent();
            ConcreteDecoratorA d1 = new ConcreteDecoratorA();
            ConcreteDecoratorB d2 = new ConcreteDecoratorB();

            d1.SetComponent(c);
            d2.SetComponent(d1);
            d2.Operation();

            Console.ReadKey();
        }
    }
}

namespace DecoratorPatternPerson
{
    class DecoratorPatternPerson
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hysen");
            Console.WriteLine("First dress up:");

            TShirts shirts = new TShirts();
            BitTrouser bitTrouser = new BitTrouser();
            Tie tie = new Tie();
            LeatherShoes leatherShoes = new LeatherShoes();

            //大T恤 垮裤 领带 皮鞋 装扮的Hysen
            shirts.Decorate(bitTrouser);
            bitTrouser.Decorate(tie);
            tie.Decorate(leatherShoes);
            leatherShoes.Decorate(person);
            shirts.Show();

            //皮鞋 领带 垮裤 大T恤 装扮的Hysen
            //shirts.Decorate(person);
            //bitTrouser.Decorate(shirts);
            //tie.Decorate(bitTrouser);
            //leatherShoes.Decorate(tie);
            //leatherShoes.Show();

            Console.ReadKey();
        }
    }
}
