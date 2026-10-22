var productList = new List<string> { };
Console.WriteLine("Enter your product names (type 'exit' to finish):");

while (true)
{
    var productName = Console.ReadLine();
    if (productName == null || productName.ToLower().Trim() == "exit")
    {
        break;
    }

    if (string.IsNullOrWhiteSpace(productName))
    {
        Console.WriteLine("Input cannot be empty.");
        continue;
    }

    var parts = productName.Trim().Split('-');
    if (parts.Length != 2)
    {
        Console.WriteLine("Product must contain a dash (-)");
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
        Console.WriteLine("The left side must contain letters only.");
        continue;
    }
    if (!int.TryParse(parts[1], out int number))
    {
        Console.WriteLine("The right side must contain numbers only.");
        continue;
    }
    if (number < 200 || number > 500)
    {
        Console.WriteLine("The numeric part must be between 200 and 500.");
        continue;
    }

    {
        productList.Add(productName.Trim());
    }
}
productList.Sort();
Console.WriteLine("\nProducts added!");
{
    foreach (var product in productList)
    {
        Console.WriteLine("Product: " + product);
    }
}

