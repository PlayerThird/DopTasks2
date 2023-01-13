//Формируется массив из n целых чисел от -40 до 40
//Выводятся нечет, отрицательные числа и их кол-во
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullProjectNet5
{
    internal class Task7
    {
        internal void Start()
        {
            void PrintMass(string text, int[] mass)
            {
                Console.Write(text + " ");
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.Write($"{mass[i]} ");
                }
                Console.WriteLine();
            }
            Console.Clear();
            int size = Checker.CheckInput<int>(x => x <= 0, "Введите размер массива", "Введите положительный размер");
            int[] mass = new int[size];
            for (int i = 0; i < size; i++)
            {
                mass[i] = new Random().Next(-40, 41);
            }
            int coll = 0;
            PrintMass("Введённый массив =", mass);
            for (int i = 0; i < mass.Length; i++)
            {
                if (Math.Abs(mass[i]) % 2 == 1 && mass[i] < 0)
                {
                    Console.WriteLine($"Нечетные отрицательные числа = {mass[i]} ");
                    coll++;
                }

            }
            Console.WriteLine($"Количество нечет, отрицат чисел = {coll}");

        }
    }
    
}
