// Faça um programa que leia um número e mostre a tabuada de multiplicação dele.

using System;

class Tabuada {
    static void Main() {

        Console.WriteLine("----------TABUADA----------");
        
        bool conversao = false; // variável que controla o loop
        
        //  Loop continua até o usuário digitar um número inteiro
        do {
            Console.WriteLine("Digite um número inteiro:");

            // Verifica se o input equivale a um número inteiro
            bool sucesso = int.TryParse(Console.ReadLine(), out int numero);

            // Se sim, executa os cálculos da tabuada
            if (sucesso) {
                Console.WriteLine("---------------------");
                Console.WriteLine($"TABUADA do {numero}");

                // Mostra a tabuada já com o resultado da multiplicação
                for (int i = 1; i <= 9; i++) {
                    Console.WriteLine($"{numero} x {i} = {numero*i}"); 
                }

                Console.WriteLine("---------------------");            
                conversao = true; 
            
            // Caso não, mostra mensagem e retorna para o loop
            } else {
                Console.WriteLine("Input inválido, digite um número inteiro.");            
            }

        } while (!conversao);
    }
}