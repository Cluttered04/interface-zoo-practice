using System;

namespace interfaces_flowershop {
    class Penguin : ISwimming, IWalking
    {
        public int maximumDepth { get; set; }
        public bool isMammal { get; set; }
        public bool isSaltWater { get; set; }
        public int numberOfLegs { get; set; }
        public string name {get; set;}
        public void slide(){
            Console.WriteLine($"{name} the penguin is sliding.");
        }

        public void swim()
        {
            Console.WriteLine($"{name} the penguin is swimming.");
        }

        public void walk()
        {
            Console.WriteLine($"{name} the penguin is walking.");
        }
    }
}