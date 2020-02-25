using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class TestPaperB:TestPaper
    {
        protected override string Answer1()
        {
            return "c";
        }

        protected override string Answer2()
        {
            return "b";
        }

        protected override string Answer3()
        {
            return "a";
        }
    }
}
