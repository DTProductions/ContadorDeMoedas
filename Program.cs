int cents = 0, input = 0;
float BRL;

Console.Write("Quantas moedas de 50 Centavos você possui? ");
input = ValidateReadLineInputToInt();
cents += input * 50;

Console.Write("Quantas moedas de 25 Centavos você possui? ");
input = ValidateReadLineInputToInt();
cents += input * 25;

Console.Write("Quantas moedas de 10 Centavos você possui? ");
input = ValidateReadLineInputToInt();
cents += input * 10;

Console.Write("Quantas moedas de 5 Centavos você possui? ");
input = ValidateReadLineInputToInt();
cents += input * 5;

BRL = (float) cents / 100;
Console.WriteLine("Você possui R$ " + BRL);

int ValidateReadLineInputToInt(){
    int value = 0;
    while(!int.TryParse(Console.ReadLine(), out value)){
        Console.Write("Input inválido, digite um número: ");
    }
    return value;
}