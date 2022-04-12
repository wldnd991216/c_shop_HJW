using System;

namespace a201827061_HJW
{
    class MainApp2
    {
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine("x:{0}, y:{1}", x, y);

            Swap(x, y);

            Console.WriteLine("x:{0}, y:{1}", x, y);
        }
    }
}