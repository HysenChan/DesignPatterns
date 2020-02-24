using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;

        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        public Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        /// <summary>
        /// 设置个人信息
        /// </summary>
        /// <param name="sex">性别</param>
        /// <param name="age">年龄</param>
        public void SetPersonalInfo(string sex,string age)
        {
            this.sex = sex;
            this.age = age;
        }

        /// <summary>
        /// 设置工作信息
        /// </summary>
        /// <param name="timeArea">工作时长</param>
        /// <param name="company">工作公司</param>
        public void SetWorkExperience(string workDate,string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        public void Diplay()
        {
            Console.WriteLine("{0} {1} {2}",name,sex,age);
            Console.WriteLine("工作经历：{0} {1}",work.WorkDate,work.Company);
        }

        public object Clone()
        {
            Resume obj = new Resume(work);
            obj.name = name;
            obj.sex = sex;
            obj.age = age;
            return obj;
        }
    }
}
