using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher a = new Teacher("mrs. Smith", 32);
            Child b = new Child("Sam", 5);
            Random rdm = new Random((int)DateTime.Now.Ticks);
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());
            for (int i = 0; i < 6; i++) 
            {
                int i1 = rdm.Next(0, 9);
                int i2 = rdm.Next(0, 9);
                Teacher_Point j1 = new Teacher_Point(i1);
                Child_Point j2 = new Child_Point(i2);
                a.Add_Point(j1);
                b.Add_Point(j2);
            }


            int[] s1 = a.All_Points();
            Console.WriteLine("Teacher's points");
            for (int i = 0; i < s1.Length; i++)
            {
                Console.Write(s1[i]);
                Console.Write(' ');
            }
            Console.WriteLine("Sum of Points");
            Console.WriteLine(a.Sum_Points());
            Console.WriteLine($"Level: {a.Point_Level()}");

            int[] s2 = b.All_Points();
            Console.WriteLine("Child's points");
            for (int i = 0; i < s2.Length; i++)
            {
                Console.Write(s2[i]);
                Console.Write(' ');
            }
            Console.WriteLine("Sum of Points");
            Console.WriteLine(b.Sum_Points());
        }
    }
}
