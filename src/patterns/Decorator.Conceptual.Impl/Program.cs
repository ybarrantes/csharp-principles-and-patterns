using Decorator.Conceptual;
using Decorator.Conceptual.Contracts;
using Decorator.Conceptual.Decorators;

var coffee = new SimpleCoffee();
PrintCoffeeInfo(coffee);

var coffeeWithMilk = new MilkDecorator(coffee);
PrintCoffeeInfo(coffeeWithMilk);

var coffeeWithMilkAndPacking = new PackingDecorator(coffeeWithMilk);
PrintCoffeeInfo(coffeeWithMilkAndPacking);

var carajillo = GetCarajillo();
PrintCoffeeInfo(carajillo);

var carajilloWithPacking = new PackingDecorator(carajillo);
PrintCoffeeInfo(carajilloWithPacking);

return;

static void PrintCoffeeInfo(ICoffee coffee)
{
    Console.WriteLine($"Cost: {coffee.GetCost()} | Description: {coffee.GetDescription()}");
}

static ICoffee GetCarajillo()
{
    ICoffee coffee = new SimpleCoffee();
    coffee = new MilkDecorator(coffee);
    coffee = new IceDecorator(coffee);
    coffee = new BaileysDecorator(coffee);
    
    return coffee;
}
