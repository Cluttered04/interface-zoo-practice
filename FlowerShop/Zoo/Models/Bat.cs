using System;

namespace interfaces_flowershop {
    public class Bat : IFlying
    {
        public int maximumHeight { get; set; }
        public int speed { get; set; }
        public bool hasFeathers { get; set; }

        public void fly()
        {
            throw new NotImplementedException();
        }
    }
}