bool runProgram = true;
double price = 0;

Dictionary<string, double> menu = new Dictionary<string, double>();
menu.Add("Shampoo", 5.99);
menu.Add("Conditioner", 6.99);
menu.Add("Lip Gloss", 4.99);
menu.Add("Mascara", 7.99);
menu.Add("Eyeliner", 8.99);
menu.Add("Eyeshadow", 10.99);
menu.Add("Concealer", 9.99);
menu.Add("Highlighter", 8.99);


List<string> ShoppingCart = new List<string>(); //list of keys


Console.WriteLine("Welcome to Sephora!\n");



Console.WriteLine(String.Format("{0, -20} {1, -20}", "Item", "Price"));
Console.WriteLine("================================");

foreach(KeyValuePair<string, double> kvp in menu)
{
    Console.WriteLine(String.Format("{0,-20} ${1,-20}", kvp.Key, kvp.Value));
}


while (runProgram)
{
    

    while (true)
    {
        Console.WriteLine("\nWhich item would you like?");
        string item = Console.ReadLine();

        if (menu.ContainsKey(item))
        {
            price = menu[item];
            ShoppingCart.Add(item);
            Console.WriteLine($"{item} for ${price} has been added to your cart");
            break;
        }
        else
        {
            Console.WriteLine("Sorry, we do not have that.");
        }
    }

    while (true)
    {
        Console.WriteLine("\nWould you like to continue shopping? y/n:");
        string keepShopping = Console.ReadLine().ToLower().Trim();
        if (keepShopping == "y")
        {
            break;
        }
        else if (keepShopping == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("That was not y/n");
        }
    }
}

Console.WriteLine("\nThanks for your order! \nHere's what you got:");

price = 0;
foreach (string itemName in ShoppingCart)
{
    
    price += menu[itemName];
    Console.WriteLine(String.Format("{0,-20} ${1,-20}", itemName, menu[itemName]));
}

Console.WriteLine("\nYour total is: $" + price);


