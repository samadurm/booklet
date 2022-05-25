using System;

namespace BookletCore
{
    class Store
    {
        private string? address;
        private long _storeNumber { get; }
        public long StoreNumber 
        { 
            get
            {
                Console.WriteLine($"Calling the getter, store number is {_storeNumber}");
                return _storeNumber;
            } 
        }


        public void MyMethod()
        {
            Console.WriteLine("Called MyMethod");
        }

    };
}