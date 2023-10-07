int numberOfStudents = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> studentsGrades = new Dictionary<string, List<decimal>>();

for (int i = 1; i <= numberOfStudents; i++)
{
    string input = Console.ReadLine();

    string name = input.Split()[0];
    decimal grade = decimal.Parse(input.Split()[1]);

    if (!studentsGrades.ContainsKey(name))
    {
        studentsGrades.Add(name, new List<decimal>());
    }

    studentsGrades[name].Add(grade);
}

foreach (var student in studentsGrades)
{
    string name = student.Key;
    List<decimal> grades = student.Value;
    decimal average = grades.Average();
    Console.WriteLine($"{name} -> {String.Join(" ", grades.Select(grade => $"{grade:F2}"))} (avg: {average:f2})");
}