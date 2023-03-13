using System;

class Programa {
    static void Main(string[] args) {
        int idade = 15;
        int qntPessoas = 1;
        bool estaAcompanhado = qntPessoas > 1; // true

        if(idade >= 16 || estaAcompanhado) {
            Console.WriteLine("pode entrar.");
        } else {
            Console.WriteLine("não pode entrar.");
        }


        Console.WriteLine("tecle enter p/ fechar.");
        Console.ReadLine();
    }
}
