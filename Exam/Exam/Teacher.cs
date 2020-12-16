using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Teacher : IPercon
    {
        public string Name;
        public int Age;
        public  Teacher_Point[] Points = { };

        public Teacher(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public int[] All_Points()
        {
            int[] s = { };
            for(int i = 0; i < Points.Length; i++)
            {
                Array.Resize(ref s, s.Length + 1);
                s[i] = Points[i].Nomber;
            }
            return s;
        }
        public int Sum_Points()
        {
            int sum = 0;
            for (int i = 0; i < Points.Length; i++)
            {
                sum += Points[i].Nomber;
            }
            return sum;
        }
        public string Point_Level()
        {
            string s = "";
            if (this.Sum_Points() >= 10)
                s = "bronze";
            if (this.Sum_Points() >= 20)
                s = "silver";
            if (this.Sum_Points() >= 30)
                s = "gold";
            return s;
        }
        public void Add_Point(Point i)
        {
            if (i is Teacher_Point)
            {
                Teacher_Point a = i as Teacher_Point;
                Array.Resize(ref Points, Points.Length + 1);
                Points[Points.Length-1] = a;
            }
        }

        public override string ToString()
        {
            return $"Teacher {this.Name} {this.Age} years old";
        }
    }
}
