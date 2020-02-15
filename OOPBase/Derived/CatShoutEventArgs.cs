using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBase
{
    class CatShoutEventArgs:EventArgs
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
