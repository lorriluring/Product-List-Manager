var productList = new List<string> {};
Console.WriteLine ("Enter your product names (type 'exit' to finish):");
while (true)
{
    var productName = Console.ReadLine();
    if (productName == null || productName.ToLower().Trim() == "exit")
    {
        break;
    }
    if (!string.IsNullOrWhiteSpace(productName))
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

