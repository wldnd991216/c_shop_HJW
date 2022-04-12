using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a201827061_HJW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30 };
            Console.WriteLine("Main() before: arr[0] = {0}",arr[0]);

            Change(arr);
            Console.WriteLine("Main() before: arr[0] = {0}",arr[0]);

            Student sl = new Student();
            sl.name = "Alpha";
            Console.WriteLine("Main() before: " + sl.name);

            Change(sl);
            Console.WriteLine("Main() before: " + sl.name);
        }



        private static void Change(int[] arr)
        {
            arr[0] = -10;
        }

        private static void Change(Student sl)
        {
            sl.name = "Beta";
        }

    }

    class Student
    {
        public string name;
    }


}