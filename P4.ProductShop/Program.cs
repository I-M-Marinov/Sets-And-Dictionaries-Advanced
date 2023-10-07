List<string> input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

SortedDictionary<string, Dictionary<string, double>> storesDictionary = new SortedDictionary<string, Dictionary<string, double>>();


while (input[0] != "Revision")
{
    string store = input[0];
    string product = input[1];
    double price = double.Parse(input[2]);

    if (!storesDictionary.ContainsKey(store))
    {
        storesDictionary.Add(store, new Dictionary<string, double>());
    }
    storesDictionary[store].Add(product, price);

    input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
}

foreach (var store in storesDictionary)
{
    Console.WriteLine($"{store.Key}->");

    foreach (var product in store.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}