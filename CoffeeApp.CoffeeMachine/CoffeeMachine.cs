using System;
using System.Collections.Generic;
using CoffeeApp.CoffeeMachine.Coffees;
using CoffeeApp.CoffeeMachine.CoffeeEnums;

namespace CoffeeApp.CoffeeMachine
{
    class CoffeeMachine
    {
        int water, milk, beans, cups, money;
        List<ICoffee> coffeeTypes = new List<ICoffee>()
        {
            new Espresso(),
            new Latte(),
            new Cappucino()
        };
        
        public CoffeeMachine(int water = 400,
                             int milk = 540,
                             int beans = 120,
                             int cups = 9,
                             int money = 550)
        {
            this.water = water;
            this.milk = milk;
            this.beans = beans;
            this.cups = cups;
            this.money = money;
        }

        void MakeCoffee(CoffeeTypes coffeeName)
        {
            var chosenCoffee = coffeeTypes.Find(coffee => coffee.name == coffeeName);

            if (CheckState(chosenCoffee))
            {
                this.water -= chosenCoffee.water;
                this.milk -= chosenCoffee.milk;
                this.beans -= chosenCoffee.beans;
                this.money += chosenCoffee.cost;
                this.cups--;
            }
        }

        void Fill(int water, int milk, int beans, int cups)
        {
            this.water += water;
            this.milk += milk;
            this.beans += beans;
            this.cups += cups;
        }

        void Take()
        {
            Console.WriteLine("I gave you {0}", this.money);
            this.money = 0;
        }

        bool CheckState(ICoffee chosenCoffee)
        { 
            if (this.water < chosenCoffee.water)
            {
                Console.WriteLine("Sorry, not enough water!");
                return false;
            }

            if (this.milk < chosenCoffee.milk)
            {
                Console.WriteLine("Sorry, not enough milk!");
                return false;
            }

            if (this.beans < chosenCoffee.beans)
            {
                Console.WriteLine("Sorry, not enough coffee beans!");
                return false;
            }

            if (this.cups < 1)
            {
                Console.WriteLine("Sorry, not enough disposable cups of coffee!");
                return false;
            }

            else
            {
                Console.WriteLine("I have enough resources, making you a coffee!");
                return true;
            }
        }
        
        void PrintState()
        {
            Console.WriteLine('\n' + "The coffee machine has:");
            Console.WriteLine("{0} of water", this.water);
            Console.WriteLine("{0} of milk", this.milk);
            Console.WriteLine("{0} of coffee beans", this.beans);
            Console.WriteLine("{0} of disposable cups", this.cups);
            Console.WriteLine("{0} of money", this.money);
        }

        public void Start()
        {
            bool loopStatement = true;
            while (loopStatement)
            {
                Console.WriteLine('\n' + "Write action (buy, fill, take, remaining, exit):");

                switch (Console.ReadLine())
                {
                    case "exit":
                        Console.WriteLine("End of the program");
                        loopStatement = false;
                        break;
                    
                    case "buy":
                        string coffeeType;

                        do
                        {
                            Console.WriteLine('\n' + "What do want to buy? 1 - espresso, 2 - latte, 3 - cappuccino:");
                            coffeeType = Console.ReadLine(); 

                            switch (coffeeType)
                            {
                                case "1":
                                    MakeCoffee(CoffeeTypes.Espresso);
                                    coffeeType = "back";
                                    break;
                                
                                case "2":
                                    MakeCoffee(CoffeeTypes.Latte);
                                    coffeeType = "back";
                                    break;
                                
                                case "3":
                                    MakeCoffee(CoffeeTypes.Cappucino);
                                    coffeeType = "back";
                                    break;
                                
                                default:
                                    break;
                            }
                        } while (coffeeType != "back");
                        
                        break;

                    case "fill":
                        Console.WriteLine("Write how many ml of water do you want to add:");
                        var water = Int32.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Write how many ml of milk do you want to add:");
                        var milk = Int32.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Write how many grams of coffee beans do you want to add:");
                        var beans = Int32.Parse(Console.ReadLine());
                        
                        Console.WriteLine("Write how many disposable cups of coffee do you want to add:");
                        var cups = Int32.Parse(Console.ReadLine());
                        
                        Fill(water, milk, beans, cups);
                        break;

                    case "take":
                        Take();
                        break;

                    case "remaining":
                        PrintState();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}