List<double> numbersList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

Dictionary<double, int> numbersDictionary = new Dictionary<double, int>();

foreach (var number in numbersList)
{
    if (!numbersDictionary.ContainsKey(number))
    {
        numbersDictionary.Add(number, 1);
    }
    else
    {
        numbersDictionary[number]++;
    }
}

foreach (var number in numbersDictionary)
{
    Console.WriteLine($"{number.Key} - {number.Value} times");
}
