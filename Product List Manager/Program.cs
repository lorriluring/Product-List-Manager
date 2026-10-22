string productList = new List<string> {};
Console.WriteLine ("Enter your product names (type 'exit' to finish):");

while (true)
{
    string productName = Console.ReadLine();
    if (productName == "exit")
    {
        break;
    }
    if (!string.IsNullOrWhiteSpace(productName))
    {
        productList.Add(productName);
    }
}

    Console.WriteLine("\nProducts added!");
{
    foreach (var product in productList)
    {
        Console.WriteLine(product);
    }
}
