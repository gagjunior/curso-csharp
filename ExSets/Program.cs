using ExSets.Entities;

HashSet<Estudent> estudents = new HashSet<Estudent>();

Console.Write("How many students for course A? ");
int numberOfStudents = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfStudents; i++)
{
    int id = int.Parse(Console.ReadLine());
    estudents.Add(new Estudent(id));
}

Console.Write("How many students for course B? ");
numberOfStudents = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfStudents; i++)
{
    int id = int.Parse(Console.ReadLine());
    estudents.Add(new Estudent(id));
}

Console.Write("How many students for course C? ");
numberOfStudents = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfStudents; i++)
{
    int id = int.Parse(Console.ReadLine());
    estudents.Add(new Estudent(id));
}

Console.WriteLine("Total students: " + estudents.Count);
