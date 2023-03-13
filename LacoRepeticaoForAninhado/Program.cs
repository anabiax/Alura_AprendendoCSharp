using System;

class Programa{
    static void Main(string[] args){
        
        double fatorRendimento = 1.005;
        double investimento = 1000;

        for(int anos = 1; anos <= 5; anos++) {
            for(int mes = 1; mes <= 12; mes++){
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001; // a cada ano ele vai aumentar 000.2... alguma coisa
        }

    Console.WriteLine("Depois de 5 anos você terá: " + investimento.ToString("F"));

    Console.WriteLine("tecle enter p/ fechar.");
    Console.ReadLine();
    }
}