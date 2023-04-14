Console.WriteLine($"Qual tabuada você quer saber?");
int tabuada = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
     Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
}
