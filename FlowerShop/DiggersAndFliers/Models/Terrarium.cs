using System;
using System.Collections.Generic;

namespace interfaces_flowershop {
    class Terrarium {
        public List<IMoveOnGround> MovesOnGround {get; set;} = new List<IMoveOnGround>();
    }
}