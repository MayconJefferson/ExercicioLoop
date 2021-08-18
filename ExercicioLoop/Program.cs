using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que leia o nome e o valor de 2 notas de um aluno e depois faça a média das duas notas se a média ficou maior que 5 aluno aprovado menor que 5 aluno reprovado
             se a nota for entre 0, você não aprendeu nada 
            a nota for entre 1 a 4 você está reprovado 
            a nota for entre 5 a 7 você passou raspando
            se a nota for 8 ou 9 você mandou bem
            se a nota for 10, parabéns vc é muito inteligente 

            Danilo é um professor de matemática e ele precisa de um programa para calcular a tabuada,
            faça um programa que solicite o número da tabuada e mostre na tela o resultado.

            int nota1, nota2, media;

            Console.WriteLine("Qual o nome do aluno?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a primeira nota?");
            nota1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a segunda nota?");
            nota2 = Convert.ToInt32(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            if(media == 0)                   Console.WriteLine($"{nome}, voce não aprendeu nada, sua media é {media}!");
            else if(media >=1 && media <=4)  Console.WriteLine($"{nome}, Infelizmente voce foi reprovado com media {media}!");
            else if(media >=5 && media <= 7) Console.WriteLine($"{nome} você passou raspando com media {media}!");
            else if(media ==8 || media == 9) Console.WriteLine($"{nome} você mandou bem com media {media}!");
            else                             Console.WriteLine($"Parabéns {nome}, você é muito inteligente, teve uma media {media}!");
            Console.Read(); */

            int sair = 0;
            do
            {
                Console.WriteLine("Qual a tabuada que deseja saber?");
                int numero = Convert.ToInt32(Console.ReadLine());

                for (int n = 0; n < 11; n++)
                {
                    Console.WriteLine($"{numero}x{n}={numero * n}\n");
                }
                Console.WriteLine("Digite 1 para fazer outra tabuada ou 0 para sair;");
                sair = Convert.ToInt32(Console.ReadLine());
            }
            while (sair == 1);

            Console.ReadKey();    
        }   
    }
}
