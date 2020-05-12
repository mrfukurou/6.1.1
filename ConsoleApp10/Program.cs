using System;

namespace ConsoleApp10
{
    class Program
    {
        static int[] Input()
        {
                Console.Write("Введите размерность массива:");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    Console.Write("a[{0}]= ", i);
                    a[i] = int.Parse(Console.ReadLine());
                }
                return a;
           
            
        } 

        static void Change(int[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; ++i)
                sum += a[i];
            Console.WriteLine("Сумма всех элементов массива: "+sum);
            if (sum <= 999 && sum>99) Console.WriteLine("Сумма является трехзначным числом"); 
            else Console.WriteLine("Сумма не является трехзначным числом");
        }

        static void Main()
        {
            try { 
            int[] myArray = Input();
            Change(myArray);
        }
            catch { Console.Write("Некорректный ввод!"); }
        }
    }
}
