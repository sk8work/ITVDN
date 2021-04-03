using System;

// Неявно типизированные массивы

namespace _006_VarArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Массив Int32
            var array1 = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array1.GetType());

            // Массив Doubles
            var array2 = new[] { 3.1415, 1, 6 };
            Console.WriteLine(array2.GetType());

            // Не компилируется (Несовместные типы)
            // var array3 = new[] { 1, "string" };

            // Delay
            Console.ReadKey();
        }
    }
}
