using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_10_1._11_Polymorphism
{
    public class ElementarySchoolGradeCard:BasicGradeClass
    {
        public override void DisplayGrade()
        {
            Console.WriteLine("This is an elementary school grade card.");
        }
    }

}
