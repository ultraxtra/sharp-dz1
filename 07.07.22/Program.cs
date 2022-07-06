using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //Program1();
            //Program2();
            //Program3();
            //Program4();
            //Program5();
            //Program6();
            //Program7();
            Console.OutputEncoding = Encoding.Unicode;
            Console.ReadKey(true);

        }

        public static int EnterInt32(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string str = Console.ReadLine();
                if (int.TryParse(str, out int value))
                {
                    return value;
                }
                Console.WriteLine("\t\tПомилка введення!!!");
            }
        }

        static void Program1()
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = i.ToString();
                if (i % 3 == 0)
                {
                    result = "Fizz";
                    if (i % 5 == 0) result = "FizzBuzz";
                }
                else if (i % 5 == 0) result = "Buzz";
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }






        static void Program2()
        {
            Console.WriteLine("Введіть число ");
            double ch = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть відсоток ");
            double vid = Convert.ToInt16(Console.ReadLine());

            double sum;
            sum = (ch * vid) / 100;

            Console.WriteLine($"\t{vid} Відводків від {ch} дорівнює {sum} ");
        }

        static void Program3()
        {

            Console.WriteLine("Введіть число 1 ");
            double ch1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть число 2 ");
            double ch2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть число 3 ");
            double ch3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть число 4 ");
            double ch4 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Числа {ch1}{ch2}{ch3}{ch4}");

        }

        static void Program4()
        {

            int a1, a2, a3, a4, a5, a6;
            Console.WriteLine("Введіть  Першу цифру шістезначного числа ");
            a1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Другу цифру шістезначного числа ");
            a2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Третю цифру шістезначного числа ");
            a3 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Четверту цифру шістезначного числа ");
            a4 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  П'яту цифру шістезначного числа ");
            a5 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введіть  Шосту цифру шістезначного числа ");
            a6 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine($"Ваше число {a1}{a2}{a3}{a4}{a5}{a6}");

            Console.WriteLine("Введіть номер пари чисел які б ви хотіли поміняти містями");
        }


        static void Program5()
        {
            Console.Write("Enter date->");
           
            string dateTime = Console.ReadLine();
            DateTime date = DateTime.Parse(dateTime);
            Console.WriteLine($"Day: {date.Day} \t Month:{date.Month}\t Year:{date.Year}");
        }

        static void Program6()
        {
            Console.WriteLine("Enteer temperature");
            double a;
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose how to convertate 1.Cels to Far 2.Far to Cel");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double result = a * 1.8 + 32;
                    Console.WriteLine($"Farengeith: {result}");
                break;
                
                case 2:
                    double resultt = (a - 32) / 1.8;
                    Console.WriteLine($"Celsium: {resultt}");
                    break;
            }
        }

        static void Program7()
        {
            Console.WriteLine("Enter diapason");
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            if(a > b)
            {
                Console.WriteLine($"{b} {a}");
            }
            else { 
                Console.WriteLine($"{a} {b}");
            }
        }

    }
}
