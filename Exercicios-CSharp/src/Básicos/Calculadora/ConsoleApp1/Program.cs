Console.WriteLine("Calculadora Simples em C#");

Console.Write("Digite o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Escolha a operação:");
Console.WriteLine("1 - Adição (+)");
Console.WriteLine("2 - Subtração (-)");
Console.WriteLine("3 - Multiplicação (*)");
Console.WriteLine("4 - Divisão (/)");
Console.Write("Digite o número da operação: ");
string operacao = Console.ReadLine();

double resultado;

switch (operacao)
{
    case "1":
        resultado = num1 + num2;
        Console.WriteLine("Resultado: " + resultado); 
        break;
    case "2":
        resultado = num1 - num2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case "3":
        resultado = num1 * num2;
        Console.WriteLine("Resultado: " + resultado);
        break;
    case "4":
        if (num2 != 0)
        {
            resultado = num1 / num2;
            Console.WriteLine("Resultado: " + resultado);
        }
        else
        {
            Console.WriteLine("Inválido, não pode dividir por zero");
        }
        break;
    default:
        Console.WriteLine("Escolha uma operação válida");
        break;

}
