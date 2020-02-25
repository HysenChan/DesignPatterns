using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class TemplateMethodPatternMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("甲抄的试卷：");
            TestPaper testPaperA = new TestPaperA();
            testPaperA.TestQusetion1();
            testPaperA.TestQusetion2();
            testPaperA.TestQusetion3();

            Console.WriteLine("乙抄的试卷：");
            TestPaper testPaperB = new TestPaperB();
            testPaperB.TestQusetion1();
            testPaperB.TestQusetion2();
            testPaperB.TestQusetion3();
            Console.ReadKey();
        }
    }
}
