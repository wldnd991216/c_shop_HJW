﻿using System;

namespace a201827061_HJW
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("점수를 입력하세요: ");
            int score = int.Parse(Console.ReadLine());

            string grade = null;

            if (score >= 90)
                grade = "A";
            else if (score >= 80)
                grade = "B";
            else if (score >= 70)
                grade = "C";
            else if (score >= 60)
                grade = "D";
            else 
                grade = "E";

            Console.WriteLine("학점은 {0}", grade);

            switch (score / 10)
            {
                case 10:
                case 9:
                    grade = "A";
                    break;
                case 8:
                    grade = "B";
                    break;
                case 7:
                    grade = "C";
                    break;
                case 6:
                    grade = "D";
                    break;
                default:
                    grade = "E";
                    break;
            }

            Console.WriteLine("학점은 {0}" , grade);
        }
    }
}