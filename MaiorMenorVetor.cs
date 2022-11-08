// Ler um vetor com 10 inteiros e descubra o maior e o menor elemento do vetor.

 using System;

namespace CodingTankCSharp {
    class MaiorMenorVetor {
        static void Main() {

            int[] vetorInt = new int[4];
            bool sucesso = false;

            for (int i = 0; i < vetorInt.Length; i++) {
                
                do {
                    Console.WriteLine($"Digite o número inteiro da posicao {i+1} do vetor: ");
                    sucesso = int.TryParse(Console.ReadLine(), out vetorInt[i]);
                    
                } while (!sucesso);
            }    
                    
            int menor = vetorInt[0]; // int.MaxValue;
            int maior = vetorInt[0]; // int.MinVAlue;

            for (int i = 1; i < vetorInt.Length; i++) {

                if (vetorInt[i] < menor) {
                    menor = vetorInt[i];
                }
                
                if (vetorInt[i] > maior) {
                    maior = vetorInt[i];
                }            
            }

            Console.WriteLine($"Menor: {menor} | Maior: {maior}");
        }
    }
}