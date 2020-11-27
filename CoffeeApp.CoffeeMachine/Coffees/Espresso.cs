using CoffeeApp.CoffeeMachine.CoffeeEnums;

namespace CoffeeApp.CoffeeMachine.Coffees
{
    class Espresso : ICoffee
    {
        public CoffeeTypes name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }

        public Espresso()
        {
            this.name = CoffeeTypes.Espresso;
            this.water = 250;
            this.milk = 0;
            this.beans = 16;
            this.cost = 4;
        }
    }
}