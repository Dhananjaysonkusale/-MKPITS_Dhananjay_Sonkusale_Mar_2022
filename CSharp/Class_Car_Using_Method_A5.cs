using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Car_Using_Method_A5
{
    public class Car
    {
        string carname;
        string carmodel;
       
        public void getdata(string a, string b)
        {
            carname = a;
            carmodel = b;
        }   
        public void showdata()
        {
            Console.WriteLine("Car Name : " + carname);
            Console.WriteLine("Car Model : " + carmodel);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            Console.WriteLine("Enter Car Name : ");
            string carname = Console.ReadLine();
            Console.WriteLine("Enter Car Model : ");
            string carmodel = Console.ReadLine();


            car.getdata(carname, carmodel); ;
            car.showdata();

        }
    }
}
