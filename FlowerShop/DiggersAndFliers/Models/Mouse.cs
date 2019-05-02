using System;
namespace interfaces_flowershop {
    class Mouse : IMoveOnGround
    {
        public bool livesAboveGround { get; set; }
        public string name { get; set; }
    }
}