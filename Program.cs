void PrintDivider()
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine("ты");
PrintDivider();

Console.WriteLine("ты");
PrintDivider();


void Print(string name, int age)
{
    Console.WriteLine($"студент: {name}, возраст {age}");
}

Print("Егоh", 19);
PrintSeparator();
Print("антон", 167);


Console.Write("Введите свою фамилию: ");
PrintSeparator();
string surname = Console.ReadLine()!.Trim(); 
if (string.IsNullOrEmpty(surname)) { 
Console.WriteLine("Фамилия не введена. Завершение работы."); 
return; 
} 
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear); 
var assigned = Enumerable.Range(1, 10) 
.OrderBy(_ => rnd.Next()) 
.Take(2) 
.OrderBy(x => x) 
.ToList(); 
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");





void PrintSeparator()
{
    Console.WriteLine();
}

double a = double.Parse(Console.ReadLine());


void CelsiusToFahrenheit()
{
    double b = a * 9 / 5 + 32;
    Console.WriteLine(b);
}

CelsiusToFahrenheit();

