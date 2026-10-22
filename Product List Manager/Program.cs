var productList = new List<string> { };
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Enter your product names (type 'exit' to finish):");
Console.ResetColor();

while (true)
{
    var productName = Console.ReadLine();
    if (productName == null || productName.ToLower().Trim() == "exit")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(productName))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Input cannot be empty.");
        Console.ResetColor();
        continue;
    }

    var parts = productName.Trim().Split('-');
    if (parts.Length != 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Product must contain a dash (-)");
        Console.ResetColor();
        continue;
    }

    bool lettersOnly = parts[0].Length > 0;
    foreach (var c in parts[0])
    {
        if (!char.IsAsciiLetter(c))
        {
            lettersOnly = false;
        }
    }
    if (!lettersOnly)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The left side must contain letters only.");
        Console.ResetColor();
        continue;
    }
    if (!int.TryParse(parts[1], out int number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The right side must contain numbers only.");
        Console.ResetColor();
        continue;
    }
    if (number < 200 || number > 500)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The numeric part must be between 200 and 500.");
        Console.ResetColor();
        continue;
    }

    {
        productList.Add(productName.Trim());
    }
}
productList.Sort();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nProducts added!");
{
    foreach (var product in productList)
    {
        Console.WriteLine("Product: " + product);
    }
}

