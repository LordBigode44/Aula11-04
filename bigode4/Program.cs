using System;

class program{
    static void Main(){
        
        int number1, number2;
        Console.WriteLine("insira o numero 1: ");
        number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("insira o numero 2: ");
        number2 = Convert.ToInt32(Console.ReadLine());
        
        if(number1 > number2){
            Console.WriteLine($"numero maior é " + number1);
        }else{
            Console.WriteLine($"numero maior é " + number2);
        }
    }
}