using System;

namespace Classes
{
    // Вторая часть класса.
    partial class PartialClass
    {
        // Определение частичного метода.
        partial void PartialMethod()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Вызван частичный метод - PartialMethod()");
        }

        // Вызов частичного метода через метод обертку.
        public void CallPartialMethod()
        {
            PartialMethod();

            // При вызове нереализованного частичного метода компилятор его проигнорирует
            // и ошибки уровня выполнения не будет
            MyMethod();
        }

        #region Реализация частичных методов в других частях класса PartialClass - необязательна! 

        //partial void mymethod()
        //{
        //  console.writeline("реализация частичных методов в других частях класса partialclass - необязательна!");
        //}

        #endregion
    }
}