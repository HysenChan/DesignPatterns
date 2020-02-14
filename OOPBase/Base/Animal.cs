using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    abstract class Animal
    {
        protected string name = "";
        public Animal(string name)
        {
            this.name = name;
        }

        public Animal()
        {
            this.name = "无名";
        }

        protected int shoutNum = 3;
        public int ShoutNum
        {
            get { return shoutNum; }
            set { shoutNum = value; }
        }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
            {
                result += getShoutSound() + ",";
            }
            return "我的名字叫：" + name + " " + result;
        }

        protected abstract string getShoutSound();
    }
}
