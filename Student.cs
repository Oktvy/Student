using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student__s
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;

      

        public Student(string name, string surname, string group, byte point, bool IsGraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            isGraduated = IsGraduated;

        }
        public void  Pointt()
        {
            if (Point > 80) 
            {
                Console.WriteLine("Imtahana icaze verilir");
            }
            else
            {
                Console.WriteLine("Imtahana icaze verilmir");
            }
        }


    }
}
