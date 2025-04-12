using System;

class Program {
    static void Main() {
        double number1, number2, number3;

        Console.WriteLine("Insira a nota 1: ");
        number1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a nota 2: ");
        number2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Insira a nota 3: ");
        number3 = double.Parse(Console.ReadLine());

        double answer = ((number1 + number2 + number3) / 3);
        Console.WriteLine("Resultado da média: " + answer);
    }
}