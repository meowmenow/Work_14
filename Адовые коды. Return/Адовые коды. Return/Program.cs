using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Адовые_коды.Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание №1

            //double a, b, c, dis, x1, x2; //Задаём переменные
            //Console.WriteLine("Введите a:"); 
            //a = Convert.ToDouble(Console.ReadLine()); //Вводим значение а
            //Console.WriteLine("Введите b:");
            //b = Convert.ToDouble(Console.ReadLine());  //Вводим значение b
            //Console.WriteLine("Введите c:");
            //c = Convert.ToDouble(Console.ReadLine()); //Вводим значение c
            //dis = b * b - 4 * a * c; //Формула дискриминанта
            //if (dis > 0) //Дискриминант больше нуля
            //{
            //    x1= Math.Round(((-b + Math.Sqrt(dis)) / (2 * a)), 2); //Нахождение первого корня
            //    Console.WriteLine("Корень имбиря намбер ван равен:" + x1);
            //    x2 = Math.Round(((-b - Math.Sqrt(dis)) / (2 * a)), 2); //Нахождение второго корня
            //    Console.WriteLine("Корень имбиря намбер ту равен:" + x2);
            //}
            //if (dis == 0) //Дискриминант равен нулю
            //{
            //    x1 = Math.Round((-b) / (2 * a), 2); //Нахождение единственного корня
            //    x2 = x1;
            //    Console.WriteLine("Корень имбиря равен:" + x1);
            //}
            //if (dis < 0) //Дискриминант меньше нуля
            //{
            //    Console.WriteLine("Корней имбиря не найдено :3");
            //}
            //Console.ReadKey(); //Пауза

            //Задание №3
            //Даны натуральное число N и одномерный массив A1, A2, …, AN целых чисел. Определить сумму всех элементов кратных 3...
            int n, d, i, sum=0; //Заданы переменные
            Console.WriteLine("Задайте размер массива не больше десяти: ");
            while (true) //Проверка на поиск ненужных символов
            {
                try
                {
                    n = Convert.ToInt32(Console.ReadLine()); //Размер массива
                    if (n < 11) //Ограничение размера массива 
                    {
                        Console.WriteLine("Задайте диапазон: ");
                        d = Convert.ToInt32(Console.ReadLine()); //Задача диапазона
                        if (d < 15)
                        {
                            int[] mas = new int[n];
                            Random rnd = new Random(); //Генерация
                            for (i = 0; i < n; i++)
                            {
                                mas[i] = rnd.Next(d);
                            }
                            for (i = 1; i < mas.Length; i++)
                            {
                                if (mas[i] % 3 == 0) //Ищем тех, кто кратен трём
                                {
                                    sum = sum + mas[i]; //Сумма чисел, кратных трём
                                }
                            }
                            Console.WriteLine("Исходный массив: ");
                            for (i = 0; i < mas.Length; i++)
                            {
                                Console.Write(mas[i] + " ");
                            }
                            Console.WriteLine(" ");
                            Console.WriteLine("Сумма чисел кратных трём равняется: " + sum); //Выводим результат
                        }
                        else //В случае неверного заданного диапазона массива, мы узреем это:
                        {
                            Console.WriteLine("Студент задаёт диапазон массива больше пятнадцати. Ему выдаётся ошибка. 'Вот те раз'- подумал студент. 'Вот те два'-отвечает преподаватель ");
                        }
                    }
                    else //В случае неверного заданного размера массива, мы узреем это:
                    {
                        Console.WriteLine("Студент задаёт размер массива больше десяти. Ему выдаётся ошибка. 'Вот те раз'- подумал студент. 'Вот те два'-отвечает преподаватель ");
                    }
                }
                catch { Console.WriteLine("Какие буквы? Только цифры. Я же калькулятлор"); }
            }
            Console.ReadKey(); //Пауза
        }
    }
}
