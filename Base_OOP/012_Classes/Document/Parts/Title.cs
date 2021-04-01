using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Title
    {
        string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return "Верхний колонтитул отсутствует.";
            }
            set
            {
                content = value;
            }
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Content);
            Console.ResetColor();
        }
    }
}
