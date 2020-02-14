using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class MachineCat : Cat, IChange
    {
        public MachineCat():base()
        { }

        public MachineCat(string name) : base(name)
        { }

        public string ChangeThing(string thing)
        {
            return base.Shout() + "我有万能的口袋，我可以变出：" + thing;
        }
    }
}
