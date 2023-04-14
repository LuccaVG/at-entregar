Console.WriteLine($"Insira 5 numeros inteiros");

int Numero = int.Parse(Console.ReadLine());

int[] arrayNumero = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número: ");

    arrayNumero[i] = int.Parse(Console.ReadLine());     
}

foreach (int numero in arrayNumero)
{
    Console.WriteLine($"O dobro de {numero} é :  {numero * 2}");     
}
