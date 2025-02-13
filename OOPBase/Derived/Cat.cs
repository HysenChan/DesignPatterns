﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class Cat:Animal
    {
        public Cat():base()
        { }

        public Cat(string name):base(name)
        { }

        protected override string getShoutSound()
        {
            return "喵";
        }
    }

    class TomCat
    {
        private string name;
        public TomCat(string name)
        {
            this.name = name;
        }

        public delegate void CatShoutEventhandler(object sender,CatShoutEventArgs args);

        public event CatShoutEventhandler CatShout;

        public void Shout()
        {
            Console.WriteLine("喵，我是{0}.",name);

            if (CatShout!=null)
            {
                CatShoutEventArgs e = new CatShoutEventArgs();
                e.Name = this.name;
                CatShout(this, e);
            }
        }
    }
}
