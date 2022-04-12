using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a201827061_HJW
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("숫자를 입력하세요: ");
            int num = int.Parse(Console.ReadLine());
            int index;
            
            for (index = 0; index < num; index++)
            {
                Console.WriteLine("{0}는 소수가 아닙니다.", num);
                break;
            }

            if (index == num)
                Console.WriteLine("{0}는 소수입니다.", num);
        }
    }
}