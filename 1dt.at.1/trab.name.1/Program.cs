Console.WriteLine($"Insira o seu Nome");
string nome;

nome = "Carlos Roque";

nome = (Console.ReadLine());

if (nome != "Carlos Roque")
{
Console.WriteLine($"Nome de usuario ou senha incorretos");
}

Console.WriteLine($"Insira a sua Senha");

int Senha;

Senha = int.Parse(Console.ReadLine());

if (Senha == 2005)
{
    Console.WriteLine($"Acesso Permitido");
    
}
else
{
    Console.WriteLine($"Nome de usuario ou senha incorretos");
    
}