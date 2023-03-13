using System;

class Programa{
    static void Main(string[] args){
        
        for(int linhas=0; linhas < 10; linhas++) {
            for(int colunas=0; colunas < linhas; colunas++){
                Console.Write("*");
            }
            Console.WriteLine(); // pula linha
        }

        // saber múltiplos de 3
    /*  for(int j=1; j < 100; j++){
            if(j % 3 == 0){
                Console.WriteLine(j);
            }
        }
    */

    // ou
    for(int i=3; i < 100; i +=3) {
        Console.WriteLine(i);
    }

    // fatorial
    int fatorial = 1;
    for(int numero=1; numero < 11; numero++) {
        fatorial *= numero;
        Console.WriteLine("fatorial de " + numero + " = " + fatorial);
    }

    Console.WriteLine("tecle enter p/ fechar");
    Console.ReadLine();

    }
}