Console.WriteLine ("Pedra, Papel ou Tesoura?");

Console.WriteLine ("Escolha uma opção: ");
string userInput = (Console.ReadLine() ??"").ToLower();

string[] opcoes = {"pedra", "papel", "tesoura"};
Random rnd = new Random();
string escolhaComputador = opcoes[rnd.Next(opcoes.Length)];


if (userInput == escolhaComputador) { 
    Console.WriteLine($"Empate! Ambos escolheram {userInput}.");
}
else if ((userInput == "pedra" && escolhaComputador == "tesoura") ||
         (userInput == "papel" && escolhaComputador == "pedra") ||
         (userInput == "tesoura" && escolhaComputador == "papel")) {
    Console.WriteLine($"Você venceu! {userInput} vence {escolhaComputador}.");
}
else if ((userInput == "pedra" && escolhaComputador == "papel") ||
         (userInput == "papel" && escolhaComputador == "tesoura") ||
         (userInput == "tesoura" && escolhaComputador == "pedra")) {
    Console.WriteLine($"Você perdeu! {escolhaComputador} vence {userInput}.");
}
else {
    Console.WriteLine("Opção inválida. Por favor, escolha pedra, papel ou tesoura.");
}