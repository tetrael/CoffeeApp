namespace CoffeeApp.CoffeeMachine
{
    class CoffeeType
    {
        public string name { get; }
            public int water { get; }
            public int milk { get; }
            public int beans { get; }
            public int money { get; }

            public CoffeeType(string name = "blank", int water = 0, int milk = 0, int beans = 0, int money = 0)
            {
                this.name = name;
                this.water = water;
                this.milk = milk;
                this.beans = beans;
                this.money = money;
            }
    }
}