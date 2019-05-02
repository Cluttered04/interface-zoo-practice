namespace interfaces_flowershop {
    class Daisy : IMothersDayFlower, IWeddingFlower{
        public string color {get; set;}
        public string name {get; set;}
        public int length {get; set;}
        public bool smellsNice {get; set;}
    }
}