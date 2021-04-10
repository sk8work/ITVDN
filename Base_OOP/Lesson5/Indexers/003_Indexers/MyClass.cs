using System;

namespace _003_Indexers
{
    class MyClass
    {
        private string[] array = new string[5];

        // Indexer
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                else
                    return "Попытка обращения за пределы массива";
            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    Console.WriteLine("Попытка обращения за пределы массива");
            }
        }
    }
}
