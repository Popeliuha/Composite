using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        public static void ShowEducatorsInfo(Educator e)
        {
            Console.WriteLine($"HeadMaster: {e.ShowInfo()}");
            foreach(var sub in e.Subordinates)
            {
                Console.WriteLine(sub.ShowInfo()); 
            }
        }
        public static void Main(string[] args)
        {
            Educator kinderGartenHeadMaster = new Educator("Ivan", "Head of kindergarten", "1");
            Educator schoolHeadMaster = new Educator("Andrii", "Head of school", "2");
            Educator universityDecan = new Educator("Pavlo", "Decan of university", "3");

            Educator educator1 = new Educator("Maks", "Teacher", "4");
            Educator educator2 = new Educator("Petro", "Teacher", "5");
            Educator educator3 = new Educator("Vasyl", "Teacher", "6");
            Educator educator4 = new Educator("Vova", "Teacher", "7");
            Educator educator5 = new Educator("Mark", "Teacher", "8");
            Educator educator6 = new Educator("Serhii", "Teacher", "9");

            kinderGartenHeadMaster.AddToSubordinates(educator1);
            kinderGartenHeadMaster.AddToSubordinates(educator2);

            schoolHeadMaster.AddToSubordinates(educator3);
            schoolHeadMaster.AddToSubordinates(educator4);

            universityDecan.AddToSubordinates(educator5);
            universityDecan.AddToSubordinates(educator6);

            ShowEducatorsInfo(kinderGartenHeadMaster);
            ShowEducatorsInfo(schoolHeadMaster);
            ShowEducatorsInfo(universityDecan);
        }
    }
}
