using System;
using System.Collections.Generic;
using System.Text;

namespace Exam
{
    class Child : IPercon
    {
        public string Name;
        public int Age;
        public  Child_Point[] Points = { } ;

        public Child(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int[] All_Points()
        {
            int[] s = { };
            for (int i = 0; i < Points.Length; i++)
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
        public void Add_Point(Point i)
        {
            if (i is Child_Point)
            {
                Child_Point a = i as Child_Point;
                Array.Resize(ref Points, Points.Length + 1);
                Points[Points.Length-1] = a;
            }
        }

        public override string ToString()
        {
            return $"Child {this.Name} {this.Age} years old";
        }

    }
}
