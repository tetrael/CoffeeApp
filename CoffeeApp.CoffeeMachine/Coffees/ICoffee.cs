using CoffeeApp.CoffeeMachine.CoffeeEnums;

namespace CoffeeApp.CoffeeMachine.Coffees
{
    interface ICoffee
    {
        public CoffeeTypes name { get; }
        public int water { get; }
        public int milk { get; }
        public int beans { get; }
        public int cost { get; }
    }
}