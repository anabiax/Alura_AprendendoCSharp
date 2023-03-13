using System;

class Programa{
    static void Main(string[] args){
        
        double investimento = 1000;
        // rendimento 0.5% (0.005) ao mês
        
        investimento += investimento * 0.005;

        for(int i=1; i <= 12; i++){
            investimento += investimento * 0.005;
            Console.WriteLine(investimento.ToString("F"));
        }

        Console.WriteLine("tecle enter p/ fechar");
        Console.ReadLine();
    }
}