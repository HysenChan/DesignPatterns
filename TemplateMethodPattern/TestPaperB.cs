using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class TestPaperB:TestPaper
    {
        public new void TestQusetion1()
        {
            base.TestQusetion1();
        }

        public new void TestQusetion2()
        {
            base.TestQusetion2();
        }

        public new void TestQusetion3()
        {
            base.TestQusetion3();
        }

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
