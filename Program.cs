

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
    else
    {
        dt = Convert.ToDateTime(temp);
    }

    Console.Write("Id: ");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Name: ");
    string n = Console.ReadLine();

    Person p = new Person(dt, id, n);
    people.Add(p);

}

List<Person> sortedPersons = people.OrderBy(p => p.dt).ToList();

Console.WriteLine("Date Id Name");
foreach (Person p in sortedPersons)
{
    Console.WriteLine(p.dt + " " + p.id + " " + p.Name );
}
Console.ReadKey();