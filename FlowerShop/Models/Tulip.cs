namespace interfaces_flowershop {
    class Tulip : IMothersDayFlower, IWeddingFlower
    {
        public string color {get; set;}
        public int length {get; set;}
        public string name {get; set;}
        public bool smellsNice {get; set;}
        // public int length { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        // public bool smellsNice { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}