using CoffeeApp.CoffeeMachine.CoffeeEnums;

namespace CoffeeApp.CoffeeMachine.Coffees
{
    class Latte : ICoffee
    {
        public CoffeeTypes name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }

        public Latte()
        {
            this.name = CoffeeTypes.Latte;
            this.water = 350;
            this.milk = 75;
            this.beans = 20;
            this.cost = 7;
        }
    }
}