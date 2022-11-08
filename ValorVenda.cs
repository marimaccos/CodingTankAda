/* 2 - Um comerciante comprou um produto e quer vende-lo com um lucro de 45% se 
o valor da compra for menor que R$20,00; caso contrário, o lucro será de 30%. 
Entrar com o valor do produto e imprimir o valor da venda. */

using System;

namespace CodingTankCSharp {
    class ValorVenda {
        static void Main() {

            Console.WriteLine("Digite o valor do produto:");
            double valorProduto = double.Parse(Console.ReadLine());
            double valorVenda = 0; 
            
            // Se o valor do produto for menor que 20 reais o lucro será 45%
            if (valorProduto < 20) {
                valorVenda = valorProduto * 1.45; // Calcula com 45% de lucro
                Console.WriteLine("Valor da venda: " + valorVenda);

            // Caso contrário, o lucro será 30%    
            } else {
                valorVenda = valorProduto * 1.3; // Calcula com 30% de lucro
                Console.WriteLine("Valor de venda: " + valorVenda);
            }
        }
    }
}