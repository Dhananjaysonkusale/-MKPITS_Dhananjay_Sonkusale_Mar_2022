using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Student_A5
{
    class Student
    {
        public int rollNo;
        public string name;
        public int mmark;
        public int cmark;
        public int pmark;
        public int total;
        public float per;
        

        public void getdata()
        {
            
            Console.WriteLine("Enter Your Roll No : ");
            rollNo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter Your Math Mark : ");
            mmark=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Physics Mark : ");
            pmark=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Chemistry Mark : ");
            cmark=Convert.ToInt32(Console.ReadLine());
          
        }
        public void showdata()
        {
            total = mmark + pmark + cmark;
            Console.WriteLine("Total = " + total);

            per = (total / 300.0f) * 100;
            Console.WriteLine("Percetange = " + per);

            if (per >= 75)
            {
                Console.WriteLine("Grade : Distinction ");
            }
            else if (per >= 60 && per < 75)
            {
                Console.WriteLine("Grade : First division "); 
            }
            else if (per >= 40 && per < 60)
            {
                Console.WriteLine("Grade : Second division ");
            }
            else
            {
                Console.WriteLine("Fail");
            }


        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.getdata();
            student.showdata();

            Console.ReadLine();
        }
    }
}
