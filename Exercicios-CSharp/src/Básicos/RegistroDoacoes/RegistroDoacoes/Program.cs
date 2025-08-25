Console.WriteLine("Digite o valor da doação:");
float valorRecebido = float.Parse(Console.ReadLine()!);

Console.WriteLine("A doação é anônima? (true/false):");
bool doacaoAnonima = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o tipo de conta (P para Poupança, C para Corrente):");
char tipoConta = char.Parse(Console.ReadLine()!.ToUpper());

Console.WriteLine($"Valor Recebido: {valorRecebido}");
Console.WriteLine($"Doação Anônima: {doacaoAnonima}");
Console.WriteLine($"Tipo de Conta: {tipoConta}");
