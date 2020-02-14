using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class HankDog :Dog, IChange
    {
        public HankDog() : base()
        { }

        public HankDog(string name) : base(name)
        { }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有万能的尾巴，我可以变出：" + thing;
        }
    }
}
