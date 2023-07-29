using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sec_10_1._11_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects of different grade card types
            BasicGradeClass basicGradeCard = new BasicGradeClass();
            ElementarySchoolGradeCard elementarySchoolGradeCard = new ElementarySchoolGradeCard();
            MiddleSchoolGradeCard middleSchoolGradeCard = new MiddleSchoolGradeCard();
            HighSchoolGradeCard highSchoolGradeCard = new HighSchoolGradeCard();

            // Polymorphism in action - calling the DisplayGrade() method on different grade card objects
            DisplayGradeCard(basicGradeCard);
            DisplayGradeCard(elementarySchoolGradeCard);
            DisplayGradeCard(middleSchoolGradeCard);
            DisplayGradeCard(highSchoolGradeCard);
        }

        static void DisplayGradeCard(BasicGradeClass gradeCard)
        {
            gradeCard.DisplayGrade();
        }
    }
}

