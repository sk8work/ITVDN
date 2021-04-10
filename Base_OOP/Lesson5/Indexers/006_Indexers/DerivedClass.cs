using System;

namespace _006_Indexers
{
    class DerivedClass : BaseClass
    {
        private string[] derivedArray = null;

        // Constructor
        public DerivedClass()
        {
            derivedArray = new string[3];
            derivedArray[0] = "Zero!";
            derivedArray[1] = "One!";
            derivedArray[2] = "Two!";
        }

        // override indexer
        public override string this[int index]
        {
            get { return base[index] + " - " + derivedArray[index]; }
        }
    }
}
