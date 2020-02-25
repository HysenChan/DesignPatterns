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
            Console.WriteLine("c");
        }

        public new void TestQusetion2()
        {
            base.TestQusetion2();
            Console.WriteLine("b");
        }

        public new void TestQusetion3()
        {
            base.TestQusetion3();
            Console.WriteLine("a");
        }
    }
}
