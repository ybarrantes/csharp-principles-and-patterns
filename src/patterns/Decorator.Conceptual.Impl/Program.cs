using Decorator.Conceptual;
using Decorator.Conceptual.Contracts;
using Decorator.Conceptual.Decorators;

var coffee = new SimpleCoffeeConcreteComponent();
PrintCoffeeInfo(coffee);

var coffeeWithMilk = new MilkConcreteDecorator(coffee);
PrintCoffeeInfo(coffeeWithMilk);

var coffeeWithMilkAndPacking = new PackingConcreteDecorator(coffeeWithMilk);
PrintCoffeeInfo(coffeeWithMilkAndPacking);

var carajillo = GetCarajillo();
PrintCoffeeInfo(carajillo);

var carajilloWithPacking = new PackingConcreteDecorator(carajillo);
PrintCoffeeInfo(carajilloWithPacking);

return;

static void PrintCoffeeInfo(ICoffeeComponent coffee)
{
    Console.WriteLine($"Cost: {coffee.GetCost()} | Description: {coffee.GetDescription()}");
}

static ICoffeeComponent GetCarajillo()
{
    ICoffeeComponent coffeeComponent = new SimpleCoffeeConcreteComponent();
    coffeeComponent = new MilkConcreteDecorator(coffeeComponent);
    coffeeComponent = new IceConcreteDecorator(coffeeComponent);
    coffeeComponent = new BaileysConcreteDecorator(coffeeComponent);
    
    return coffeeComponent;
}
