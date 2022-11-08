/* 1 - Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
aluno. */

using System;

namespace CodingTankCSharp {
    class MediaAluno {
        static void Main() {

            // Cria vetor para armazenar as notas
            double[] notas = new double[4];
            double soma = 0;

            // Loop para armazenar as notas digitadas pelo usuário
            for (int i = 0; i < notas.Length; i++) {
                Console.WriteLine($"Digite a {i+1}a nota: ");
                notas[i] = double.Parse(Console.ReadLine());
                
                soma += notas[i]; // Soma as notas digitadas na variável
            }
        
            double media = soma / notas.Length;
            
            if (media >= 7) {                
                Console.WriteLine("Aluno aprovado! Média: " + media);
                
            } else {
                Console.WriteLine("Digite a nota de recuperacao:");
                double notaRecuperacao = double.Parse(Console.ReadLine());
                double novaMedia = (notaRecuperacao + media) / 2;

                if (novaMedia >= 7) {
                    Console.WriteLine("Aluno aprovado na recuperacao! Média: " + novaMedia);
                    
                } else {
                    Console.WriteLine("Aluno reprovado na recuperacao! Média: " + novaMedia);
                }
            }
        }
    }
}