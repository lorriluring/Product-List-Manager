// This is a simple console application that allows users to input product names in the format "name-number"
using System.Text.RegularExpressions;
var productList = new List<string> { };
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Enter your product names (type 'exit' to finish):");
Console.ResetColor();

// Start of the loop to read product names from the user
while (true)
{
    // Read the product name from the user
    var productName = Console.ReadLine();


    /* if (productName == null || productName == "exit")
    
    { 
        break;
    } */
   // productName = productName.ToLower().Trim();
    // Validate the product name
    if (string.IsNullOrWhiteSpace(productName))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Input cannot be empty.");
        Console.ResetColor();
        continue;
    }
    productName = productName.ToLower().Trim();
   if (productName == "exit")
    {
        break;
    }
    // Split the product name into parts based on the dash (-)
    var parts = productName.Split('-');
    if (parts.Length != 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Product must contain a dash (-)");
        Console.ResetColor();
        continue;
    }

    // Check if the left part contains only letters
    /*bool lettersOnly = parts[0].Length > 0;
    foreach (var c in parts[0])
    {
        // Check if the character is not an ASCII letter
        if (!char.IsAsciiLetter(c))
        {
            lettersOnly = false;
        }
    } */

    bool lettersOnly = Regex.IsMatch(parts[0], @"^[A-Za-z]+$");
    // Check if the right part contains only numbers
    if (!lettersOnly)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The left side must contain letters only.");
        Console.ResetColor();
        continue;
    }
    // Try to parse the right part as an integer
    if (!int.TryParse(parts[1], out int number))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The right side must contain numbers only.");
        Console.ResetColor();
        continue;
    }
    // Check if the number is within the specified range
    if (number < 200 || number > 500)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("The numeric part must be between 200 and 500.");
        Console.ResetColor();
        continue;
    }

    {
        // Add the valid product name to the list
        productList.Add(productName);
    }
}
// Sort the product list alphabetically
productList.Sort();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nProducts added!");
{
    // Display the sorted product list
    foreach (var product in productList)
    {
        Console.WriteLine("Product: " + product);
    }
}