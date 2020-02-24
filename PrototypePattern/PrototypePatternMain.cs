using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class PrototypePatternMain
    {
        static void Main(string[] args)
        {
            Resume resume = new Resume("小明");
            resume.SetPersonalInfo("男", "21");
            resume.SetWorkExperience("2019-2020", "IT公司");

            Resume resume1 = new Resume("小明");
            resume1.SetPersonalInfo("男", "21");
            resume1.SetWorkExperience("2019-2020", "IT公司");

            resume.Diplay();
            resume1.Diplay();
            Console.ReadKey();
        }
    }
}
