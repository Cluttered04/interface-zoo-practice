using System;
using System.Collections.Generic;

namespace interfaces_flowershop {
    class BirdCage {
        public List<IFly> fliers {get; set;} = new List<IFly>();
    }
}