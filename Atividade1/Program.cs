using System;
using Atividade1.Classes;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacidade;
            int quantidadeAndares;
            int andar = 0;
            bool check2 = true;
            int quantidade = 0;

            while (check2 == true)
            {
                bool check = true;
                bool check3 = true;

                Console.WriteLine(@"Olá, escolha o tipo de elevador
1-Elevador Social
2-Elevador de Serviço
3-Fechar
            ");
                int selecionar = int.Parse(Console.ReadLine());
                if (selecionar == 3)
                {
                    check2 = false;
                }

                if (selecionar == 1)
                {
                    Console.WriteLine("Quantos andares tem o prédio?");
                    quantidadeAndares = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a capacidade do elevador?");
                    capacidade = int.Parse(Console.ReadLine());
                    ElevadorSocial e = new ElevadorSocial();
                    e.Inicializa(capacidade, quantidadeAndares);
                    while (check == true)
                    {
                        Console.WriteLine(@"O que deseja fazer?
1-Subir andar
2-Descer andar
3-Entrar alguém
4-Sair alguém
5-Voltar para seleção anterior
                ");
                        int selecionar2 = int.Parse(Console.ReadLine());
                        if (selecionar2 == 1)
                        {
                            // e.Subir(quantidadeAndares, andar);
                            andar = e.Subir(quantidadeAndares, andar);
                            // Console.WriteLine($"NUMERO DO ANDAR = {andar}");
                        }
                        else if (selecionar2 == 2)
                        {
                            // e.Descer(quantidadeAndares, andar);
                            andar = e.Descer(quantidadeAndares, andar);
                        }
                        else if (selecionar2 == 3)
                        {
                            // e.Entrar(capacidade, quantidade);
                            quantidade = e.Entrar(capacidade, quantidade);
                            Console.WriteLine($"O elevador possui {quantidade} pessoas");
                        }
                        else if (selecionar2 == 4)
                        {
                            // e.Sair(capacidade, quantidade);
                            quantidade = e.Sair(capacidade, quantidade);
                            Console.WriteLine($"O elevador possui {quantidade} pessoas");
                        }
                        else if (selecionar2 == 5)
                        {
                            check = false;
                        }
                    }
                }
                else if (selecionar == 2)
                {
                    Console.WriteLine("Quantos andares tem o prédio?");
                    quantidadeAndares = int.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a capacidade do elevador?");
                    capacidade = int.Parse(Console.ReadLine());
                    ElevadorDeServico s = new ElevadorDeServico();
                    s.Inicializa(capacidade, quantidadeAndares);
                    while (check3 == true)
                    {
                        Console.WriteLine(@"O que deseja fazer?
1-Subir andar
2-Descer andar
3-Entrar caixa
4-Sair caixa
5-Voltar para seleção anterior
                ");
                        int selecionar2 = int.Parse(Console.ReadLine());
                        if (selecionar2 == 1)
                        {
                            s.Subir(quantidadeAndares, andar);
                            andar = s.Subir(quantidadeAndares, andar);
                            // Console.WriteLine($"NUMERO DO ANDAR = {andar}");
                        }
                        else if (selecionar2 == 2)
                        {
                            s.Descer(quantidadeAndares, andar);
                            andar = s.Descer(quantidadeAndares, andar);
                        }
                        else if (selecionar2 == 3)
                        {
                            s.Entrar(capacidade, quantidade);
                            quantidade = s.Entrar(capacidade, quantidade);
                            Console.WriteLine($"O elevador possui {quantidade} caixas");
                        }
                        else if (selecionar2 == 4)
                        {
                            s.Sair(capacidade, quantidade);
                            quantidade = s.Sair(capacidade, quantidade);
                            Console.WriteLine($"O elevador possui {quantidade} caixas");
                        }
                        else if (selecionar2 == 5)
                        {
                            check3 = false;
                        }
                    }
                }
            }
        }
    }
}
