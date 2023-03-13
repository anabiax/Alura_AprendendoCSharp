using System;

class Programa {
    static void Main(string[] args) {
        Console.WriteLine("projeto 2: criando variáveis.");
        int idade = 22;
        Console.WriteLine("minha idade é: "+ idade + " anos.");
        
        double salario = 3000.13;
        Console.WriteLine("salário: " + salario);
        // uma variável double aceita um número int, mas o inverso não rola.

        double nota = 8.0 / 3;
        Console.WriteLine(nota);

        // conversões e outros tipos
        int salarioInteiro = (int)salario; // vai arrancar a vírgula -- type casting
        Console.WriteLine(salarioInteiro);

        long x = 2000000000000;
        Console.WriteLine(x);

        short y = 15000; // trabalha com qnt de pessoas/produtos.
        Console.WriteLine(y);

        float altura = 1.57f;
        Console.WriteLine(altura);

        string nome = "Ana";
        Console.WriteLine(nome);

        char letra = 'A'; // um caracter apenas dentro de determinada variável
                            // internamente ela interpreta como um número inteiro, então p/ fazer a conversão p/ char tem que marcar.

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(69+1);
        Console.WriteLine(letra); //output: F

        
        string primeiraFrase = "Alura - cursos de tecnologia ";
        Console.WriteLine(primeiraFrase+2022); // C# permite concatenar variáveis de diferentes tipos.

        string cursos = @"Cursos:
- C#;
- JavaScript;
- React;
- Java.";
        Console.WriteLine(cursos);

        
        //atribuições de variáveis:
        int age = 30;
        int idadeAna = age;
        Console.WriteLine(idadeAna);



        Console.WriteLine("tecle enter p/ fechar.");
        Console.ReadLine();
    }
}

