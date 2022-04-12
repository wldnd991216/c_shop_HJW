﻿using System;
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
            double max = double.MinValue;
            double min = double.MaxValue;
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("키를 입력하세요 (단위cm) : ");
                double h = double.Parse(Console.ReadLine());
                if (h > max)
                    max = h;
                if (h < min)
                    min = h;
                sum += h;
            }

            Console.WriteLine("평균: {0}cm, 최대: {1}cm, 최소: {2}cm", sum / 5,max,min);
        }
    }
}