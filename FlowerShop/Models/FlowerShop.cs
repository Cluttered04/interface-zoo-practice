using System.Collections.Generic;

namespace interfaces_flowershop {
    class FlowerShop {
        public List<Tulip> createTulipBouquet() {
            return new List<Tulip>(){
                new Tulip(){
                    color = "yellow",
                    name = "awesome tulip",
                    length = 3,
                    smellsNice = true
                },
                new Tulip(){
                    color = "white",
                    name = "another awesome tulip",
                    length = 4,
                    smellsNice = false
                }
            };
        }
        public List<Daisy> createDaisyBouquet(){
            return new List<Daisy>(){
                new Daisy(){
                    color = "blue",
                    name = "awesome daisy",
                    length = 5,
                    smellsNice = true
                },
                new Daisy(){
                    color = "white",
                    name = "the pinkest daisy",
                    length = 3,
                    smellsNice = true
                }
            };
        }
        public List<Hydrangea> createHydrangeaBouquet(){
            return new List<Hydrangea>(){
                new Hydrangea(){
                    color = "purple",
                    name = "best hydrangea",
                    length = 5,
                    smellsNice = false
                },
                new Hydrangea(){
                    color = "yellow",
                    name = "second best hydrangea",
                    length = 7,
                    smellsNice = true
                }
            };
        }

        public List<IMothersDayFlower> createMothersDayBouquet(){
            return new List<IMothersDayFlower>(){
                new Daisy(){
                    length = 6,
                    smellsNice = true,
                },
                new Tulip(){
                    length = 6,
                    smellsNice = false
                }
            };
        }
        public List<IWeddingFlower> createWeddingBouquet(){
            return new List<IWeddingFlower>(){
                new Daisy(){
                    length = 6,
                    smellsNice = true,
                },
                new Tulip(){
                    length = 6,
                    smellsNice = false
                }
            };
        }



    }

// ## Lightning Exercise 2
// Choose the two flowers you want to be in the Mother's Day arrangement and make sure both have a StemLength property. Any flower in this arrangement, even in the future, needs to have a stem length of 5 inches. This means that the StemLength property must exist on those flowers. It can optional on other flowers.
// The other two flowers will be in the wedding arrangement. Flowers in the wedding arrangement will always have some white or yellow in them. That means that the Color property must be on flowers for that arrangement. It can be optional on other flowers.




}