using System;

class program{
    static void Main(){
        
        int number1;
        Console.WriteLine("insira um numero qualquer: ");
        number1 = Convert.ToInt32(Console.ReadLine());
       
        
        if(number1 %2 == 0){
            Console.WriteLine("o numero é par");
        }else{
            Console.WriteLine ("o numero é impar");
        }
    }
}