using System;

class Programa{
    static void Main(string[] args){
        
        double investimento = 1000;
        // rendimento 0.5% (0.005) ao mês

        int mes = 1;
        while(mes <= 12) {
            investimento *= 0.005;
            Console.WriteLine(investimento.ToString("F"));
            mes++;
        }


        Console.WriteLine("tecle enter p/ fechar.");
        Console.ReadLine();
    }
}