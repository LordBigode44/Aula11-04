// See https://aka.ms/new-console-template for more information
using System;

class program{
    static void Main(){
        
        
        int number1;
        Console.Write("insira seu ano de nacimento ");
        number1 = Convert.ToInt32(Console.ReadLine());
        
        int answer = 2024 - number1;
        Console.WriteLine("resultado da soma: "+answer);
    }
}