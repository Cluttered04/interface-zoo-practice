using System;
using System.Collections.Generic;

namespace interfaces_flowershop
{
    class Program
    {
        static void Main(string[] args)
        {
        //    FlowerShop myShop = new FlowerShop();
        //    List<Tulip> bouquetOfTulips = myShop.createTulipBouquet();

        //     Bat henry = new Bat(){
        //         name = "Henry",
        //         speed = 30,
        //         hasFeathers = false,
        //         isVampire = true,
        //         maximumHeight = 100
        //     };

        //     henry.fly();

        //     Penguin harryTux = new Penguin(){
        //         name = "Harry Tux",
        //         isMammal = false,
        //         isSaltWater = true,
        //         maximumDepth = 10
        //     };

        //     harryTux.swim();
        //     harryTux.walk();
        //     harryTux.slide();

        Ant harry = new Ant(){
            livesInGround = true,
            isMammal = false,
            name = "Harry"
        };

        BetaFish larry = new BetaFish(){
            isSaltWater = false,
            name = "larry"
        };

        Copperhead jerry = new Copperhead(){
            livesAboveGround = true,
            name = "Jerry"
        };

        Earthworm mary = new Earthworm(){
            livesInGround = true,
            isMammal = false,
            name = "Mary"
        };

        Finch terry = new Finch(){
            doesFly = true,
            name = "Terry"
        };

        Gerbil cary = new Gerbil(){
            livesInGround = true,
            isMammal = true,
            name = "Cary"
        };

        Mouse ferry = new Mouse(){
            livesAboveGround = true,
            name = "Ferry"
        };

        Parakeet nary = new Parakeet(){
            doesFly = true,
            name = "Nary"
        };

        Terrapin wary = new Terrapin(){
            livesAboveGround = true,
            name = "Wary"
        };

        TimberRattlesnake sairy = new TimberRattlesnake(){
            livesAboveGround = true,
            name = "Sairy"
        };

        Pool poolOne = new Pool(){};

        Terrarium terrariumOne = new Terrarium(){
        };

        BirdCage birdCageOne = new BirdCage(){};
        DirtPile pileOfDirt = new DirtPile(){};

        poolOne.swimsInWater.Add(larry);
        pileOfDirt.digsInGround.Add(harry);
        terrariumOne.MovesOnGround.Add(jerry);
        pileOfDirt.digsInGround.Add(mary);
        birdCageOne.fliers.Add(terry);
        pileOfDirt.digsInGround.Add(cary);
        terrariumOne.MovesOnGround.Add(ferry);
        birdCageOne.fliers.Add(nary);
        terrariumOne.MovesOnGround.Add(wary);
        terrariumOne.MovesOnGround.Add(sairy);












        }
    }
}
