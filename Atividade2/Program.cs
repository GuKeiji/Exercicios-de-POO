using System;
using Atividade2.Classes;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"Selecione sua posição:
1-Defesa
2-Ataque
3-Meio Campo            
            ");
            int selecionar = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite seu ano de nascimento:");
            int anoNascimento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua nacionalidade:");
            string nacionalidade = Console.ReadLine();
            Console.WriteLine("Digite sua altura:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso:");
            int peso = int.Parse(Console.ReadLine());

            if (selecionar == 1)
            {
                JogadorDef d = new JogadorDef();
                int idade = d.CalcularIdade(anoNascimento);
                d.MostrarDados(nome, anoNascimento, nacionalidade, altura, peso, idade);
                Console.WriteLine("Deseja conferir quando poderá se aposentar? (s/n)");
                string selecionar2 = Console.ReadLine().ToLower();
                if (selecionar2 == "s")
                {
                    d.Aposentar(idade, nome);
                }

            }
            else if (selecionar == 2)
            {
                JogadorAtaque a = new JogadorAtaque();
                int idade = a.CalcularIdade(anoNascimento);
                a.MostrarDados(nome, anoNascimento, nacionalidade, altura, peso, idade);
                Console.WriteLine("Deseja conferir quando poderá se aposentar? (s/n)");
                string selecionar2 = Console.ReadLine().ToLower();
                if (selecionar2 == "s")
                {
                    a.Aposentar(idade, nome);
                }

            }
            else if (selecionar == 3)
            {
                JogadorMC m = new JogadorMC();
                int idade = m.CalcularIdade(anoNascimento);
                m.MostrarDados(nome, anoNascimento, nacionalidade, altura, peso, idade);
                Console.WriteLine("Deseja conferir quando poderá se aposentar? (s/n)");
                string selecionar2 = Console.ReadLine().ToLower();
                if (selecionar2 == "s")
                {
                    m.Aposentar(idade, nome);
                }

            }
        }
    }
}
