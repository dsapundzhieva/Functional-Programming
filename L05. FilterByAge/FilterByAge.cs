using System;
using System.Collections.Generic;
using System.Linq;

class Person
{

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}
class FilterByAge
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Person> people = AddingPeople(n);

        string condition = Console.ReadLine();
        int ageThreshold = int.Parse(Console.ReadLine());
        string format = Console.ReadLine();

        Func<Person, bool> filter = FilterPeopleByConditonAnddAge(condition, ageThreshold);

        List<Person> filteredPeople = people.Where(filter).ToList();

        Action<Person> formatPeopleForPrint = PrintFormatPeople(format);

        PrintPeople(filteredPeople, formatPeopleForPrint);
    }

    private static void PrintPeople(List<Person> filteredPeople, Action<Person> formatPeopleForPrint)
    {
        filteredPeople.ToList().ForEach(formatPeopleForPrint);
    }

    private static Action<Person> PrintFormatPeople(string format)
    {
        if (format == "name")
        {
            return (Person p) => Console.WriteLine(p.Name);
        }
        else if (format == "age")
        {
            return (Person p) => Console.WriteLine(p.Age);
        }
        else if (format == "name age")
        {
            return (Person p) => Console.WriteLine($"{p.Name} - {p.Age}");
        }
        throw new ArgumentException($"Invalid format type {format}");
    }

    private static Func<Person, bool> FilterPeopleByConditonAnddAge(string condition, int ageThreshold)
    {
        if (condition == "younger")
            return p => p.Age < ageThreshold;
        if (condition == "older")
            return p => p.Age >= ageThreshold;
        throw new ArgumentException($"Invalid filter: {condition} {ageThreshold}");
    }

    private static List<Person> AddingPeople(int n)
    {
        List<Person> people = new List<Person>();
        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string name = line[0];
            int age = int.Parse(line[1]);
            Person person = new Person(name, age);
            people.Add(person);
        }
        return people;
    }



}
