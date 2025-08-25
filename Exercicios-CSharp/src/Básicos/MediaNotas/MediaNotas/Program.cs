Console.WriteLine("Digite a primeira nota do aluno: ");
float nota1 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a segunda nota do aluno: ");
float nota2 = float.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a terceira nota do aluno: ");
float nota3 = float.Parse(Console.ReadLine()!);

float media = (nota1 + nota2 + nota3) / 3;
Console.WriteLine($"A média do aluno é: {media}");
