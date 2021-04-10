using System;

namespace _006_Indexers
{
    class BaseClass
    {
        private string[] baseArray = null;

        // Constructor
        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "Ноль";
            baseArray[1] = "Один";
            baseArray[2] = "Два";
        }

       // Virtual indexer
       public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}
