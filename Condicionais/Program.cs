using System;

class Programa {
    static void Main (string[] args) {

        int idade = 16;
        int qntPessoas = 2;

        if(idade >= 18) {
            Console.WriteLine("pode entrar");
        } else {
            if(idade >= 16 && qntPessoas > 1){
                Console.WriteLine("ele está acompanhado. Pode entrar.");
            } else {
                Console.WriteLine("não pode entrar");
            }
        }

        Console.WriteLine("tecle enter p/ fechar.");
        Console.ReadLine();

    }
}