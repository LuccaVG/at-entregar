string[] carros = new string[3];

for (int i = 0; i < 3; i++)
{
    // bloco de código a ser executado
     Console.WriteLine($"Digite o {i + 1}º nome do carro:");
     carros[i] = Console.ReadLine()!;
}




for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"O {i + 1}º carro é: {carros[i]}");
    
}

// foreach (var item in carros)
// {
//     Console.WriteLine($"Nome do carro: {item}");
    
// }