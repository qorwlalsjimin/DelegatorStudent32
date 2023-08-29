using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatorStudent32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Students students = new Students();
            students.Add(new Student("백지민", 4.5));
            students.Add(new Student("배서연", 4.4));
            students.Add(new Student("양다연", 4.3));

            students.Print();
            students.Print((s) =>
            {
                Console.WriteLine("**************");
                Console.WriteLine("이름: "+s.Name);
                Console.WriteLine("학점: "+s.Score);
            });
        }
    }
}
