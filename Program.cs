using System;

namespace areaTriangulo
{

    class areaTriangulo
    {

        static void Main(string[] args)
        {
            /* 
            [M1S01] Ex 2 - Área do Triângulo 
            [Variáveis]
            Crie um programa que receba os valores da base e da altura de um triângulo qualquer, 
            e calcule a área do triângulo usando a fórmula area =(base × altura)/2 e exiba o resultado para o usuário: 
            Saída: A área do triângulo é {area}
            */

            System.Console.WriteLine("Digite a Base do Triângulo: ");
            int baseTriangulo = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a altura do Triângulo: ");
            int altura = int.Parse(Console.ReadLine());
            int area = (baseTriangulo * altura) / 2;           
            System.Console.WriteLine("A área do triângulo é " + area);

        }
    }
}