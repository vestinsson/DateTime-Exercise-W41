

using DateTime_Exercise_W41;

List<Person> people = new List<Person>();

while (true)
{
    DateTime dt;

    Console.Write("Date (yyyy-MM-dd): ");
    string temp = Console.ReadLine();
    if (temp.ToLower() == "exit")
    {
        break;
    }

    if( DateTime.TryParse(temp, out dt))
    {
        Console.Write("Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Name: ");
        string n = Console.ReadLine();


        Person p = new Person(dt, id, n);
        people.Add(p);
    }
    else
    {
        Console.WriteLine("Please enter (yyyy-MM-dd) format");
    }
}

// sort ascending by Date
List<Person> sortedPersons = people.OrderBy(p => p.dt).ToList();

// insert variable 0, 1, 2.
// negative is left aligned, positive is right aligned
const string formatStr = "{0, -20:yyyy-MM-dd} {1, -10} {2}";

Console.WriteLine(formatStr, "Date", "Id", "Name");
foreach (Person p in sortedPersons)
{
    Console.WriteLine(formatStr, p.dt, p.id, p.Name );
}
Console.ReadKey();