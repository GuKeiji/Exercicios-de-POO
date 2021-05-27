using System;
using Atividade3.Classes;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            bool checar = true;
            while (checar == true)
            {

                Console.WriteLine(@"Olá, qual deseja beber?
1-Cafézinho saboroso ( 10g de açúcar )
2-Cafézinho docinho ( quantidade de açúcar a sua escolha )
3-Desligar
            ");
                int selecionar = int.Parse(Console.ReadLine());
                if (selecionar == 1)
                {
                    m.FazerCafe();
                }
                else if (selecionar == 2)
                {
                    int acucarDisponivel = m.MostrarAcucar();
                    Console.WriteLine($"Qual a quantidade de açúcar deseja colocar? ({acucarDisponivel}g restantes)");
                    int acucar = int.Parse(Console.ReadLine());
                    m.FazerCafe(acucar);
                }
                else if (selecionar == 3)
                {
                    checar = false;
                }
            }
        }
    }
}
