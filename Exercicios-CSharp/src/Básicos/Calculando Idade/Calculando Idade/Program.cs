Console.WriteLine("Digite o ano do seu nascimento:");
int anoNascimento = int.Parse(Console.ReadLine()!);

int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;

Console.WriteLine($"Você tem {idade} anos.");
