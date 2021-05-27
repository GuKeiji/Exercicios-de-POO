using System;

namespace Atividade1.Classes
{
    public abstract class Elevador
    {

        protected int quantidadeAndares;
        protected int andar;
        protected int capacidade;
        protected int quantidade;

        public void Inicializa(int capacidade, int quantidadeAndares)
        {
            // andar = 0;
            // quantidade = 0;
            Console.WriteLine("O elevador está no térreo e vazio");
            Console.WriteLine($"Número de andares:{quantidadeAndares}");
            Console.WriteLine($"Capacidade máxima:{capacidade}");
        }
        public int Entrar(int capacidade, int quantidade)
        {
            if (quantidade < capacidade)
            {
                quantidade++;
            }
            else
            {
                Console.WriteLine($"O elevador está cheio, a capacidade é de {capacidade} pessoas");
            }
            return quantidade;
        }
        public int Sair(int capacidade, int quantidade)
        {
            if (quantidade > 0)
            {
                quantidade--;
            }
            else
            {
                Console.WriteLine($"O elevador já está vazio");
            }
            return quantidade;
        }
        public int Subir(int quantidadeAndares, int andar)
        {
            if (andar < quantidadeAndares)
            {
                andar++;
            }
            else
            {
                Console.WriteLine($"O elevador já está no andar máximo");
            }
            Console.WriteLine($"O elevador está no andar {andar}");

            return andar;
        }
        public int Descer(int quantidadeAndares, int andar)
        {
            if (andar > 0)
            {
                andar--;
            }
            else
            {
                Console.WriteLine($"O elevador está no térreo");
            }
            Console.WriteLine($"O elevador está no andar {andar}");

            return andar;
        }
    }
}