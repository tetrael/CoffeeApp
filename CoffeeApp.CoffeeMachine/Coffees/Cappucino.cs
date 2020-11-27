using CoffeeApp.CoffeeMachine.CoffeeEnums;

namespace CoffeeApp.CoffeeMachine.Coffees
{
    
    class Cappucino : ICoffee
    {
        public CoffeeTypes name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }

        public Cappucino()
        {
            this.name = CoffeeTypes.Cappucino;
            this.water = 200;
            this.milk = 100;
            this.beans = 12;
            this.cost = 6;
        }
    }
}