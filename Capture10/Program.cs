using System;

namespace a201827061_HJW
{
    class Program
    {
        static void Main(String[] args)
        {
            new FileStream(@"log", FileMode.OpenOrCreate);

            Console.Write("키를 입력하세요(cm) : ");
            double height = double.Parse(Console.ReadLine());
            height /= 100;

            Console.Write("체중을 입력하세요(kg) : ");
            double weight = double.Parse(Console.ReadLine());
            double bmi = weight / (height * height);

            //bmi < 20, 저체중
            //20 <= bmi < 25 정상체중
            //25 <= bmi < 30,경도비만
            //30 <= bmi < 40, 비만
            //mbi >= 40, 고도비만

            string comment = null;

            if (bmi < 20)
                comment = "저체중";
            else if (bmi < 25)
                comment = "정상체중";
            else if (bmi < 30)
                comment = "경도비만";
            else if (bmi < 40)
                comment = "비만";
            else 
                comment = "고도비만";

            Console.WriteLine("BMI={0:f1}, {1} 입니다.",bmi,comment);

        }
    }
}