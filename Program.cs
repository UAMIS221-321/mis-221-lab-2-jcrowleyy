class SherlenthiasSandwichShop
{
    static void Main()
    {
        const double COST_OF_SANDWICH = 4.75;
        const double COST_OF_TOPPING = 0.55;
        const double DISCOUNT_AMOUNT = 0.10;
 
        Console.Write("Enter the number of sandwiches: ");
        int numberOfSandwiches = int.Parse(Console.ReadLine());
 
        Console.Write("Enter the number of toppings: ");
        int numberOfToppings = int.Parse(Console.ReadLine());
 
        Console.Write("Enter the tip amount (as a decimal): ");
        double tip = double.Parse(Console.ReadLine());
 
        double totalSandwichCost = COST_OF_SANDWICH * numberOfSandwiches;
        double totalToppingCost = COST_OF_TOPPING * numberOfToppings;
        double baseCost = totalSandwichCost + totalToppingCost;
 
        double discountedCost = baseCost * (1 - DISCOUNT_AMOUNT);
 
        double orderCost = discountedCost + tip;
 
        Console.WriteLine($"The total order cost is: ${orderCost:F2}");
    }
}