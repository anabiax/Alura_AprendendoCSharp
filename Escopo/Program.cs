using System;

class Programa{
    static void Main(string[] args){
        
        
        int idade = 16;
        int qntPessoas = 1;
        bool estaAcompanhado = qntPessoas > 1; // true
        string textoAdicional;

        if(estaAcompanhado == true) {
            textoAdicional = "o mlk está acompanhado.";
        } else {
            textoAdicional = "o mlk não está acompanhado.";
        }

        if(idade >= 16 && estaAcompanhado){
            Console.WriteLine(textoAdicional);
            Console.WriteLine("pode entrar.");
        } else {
            Console.WriteLine("não pode entrar.");
        }



        Console.WriteLine("tecle enter p/ fechar");
        Console.ReadLine();
    }
}