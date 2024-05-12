using App3;

Employee employee = new Employee();


Console.WriteLine(employee.CalcSalary("ahmad", 250, 900, 9));



Console.WriteLine(" looop statmante ");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("i= " + i);
}

Console.WriteLine(" even ");
for (int i = 2; i <= 10; i += 2)
{
    Console.WriteLine("i= " + i);
}

Console.WriteLine(" ood ");

for (int i = 1; i <= 10; i += 2)
{
    Console.WriteLine("i= " + i);
}


Console.WriteLine(" new even ");
for (int i = 1; i <= 20; i += 3)
{


    if (i % 2 == 1)
    {
        //if (i > 4)
        Console.WriteLine("i= " + i);


    }


}


Console.WriteLine("------- Array");

int[] number = new int[4];
string msg = " ";
for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine());
    msg = msg + number[i] + "   ";
}
Console.WriteLine(msg);


Console.WriteLine("------- SUM");
double sum = 0;


for (int i = 0; i < number.Length; i++)
{
    number[i] = int.Parse(Console.ReadLine());
    sum = sum + number[i];
}
Console.WriteLine("total:  " + sum);

Console.WriteLine("------- Print Names");

string[] names = new string[] { "ahmad", "rami", "sami" };
foreach (var n in names)
{
    Console.WriteLine(n + ", ");
}







