using System;

namespace Atividade3.Classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 100;

        public void FazerCafe(int acucar)
        {
            if (acucar <= acucarDisponivel)
            {
                Console.WriteLine($"Cafézinho saboroso com {acucar}g de açúcar está pronto!");
                acucarDisponivel = acucarDisponivel - acucar;
            }
            else
            {
                Console.WriteLine("Açúcar insuficiente para fazer o cafézinho saboroso");
            }
            Console.WriteLine($"Agora tem {acucarDisponivel}g de açúcar disponível");

        }
        public void FazerCafe()
        {
            if (10 <= acucarDisponivel)
            {
                Console.WriteLine("Cafézinho saboroso com 10g de açúcar está pronto!");
                acucarDisponivel = acucarDisponivel - 10;
            }
            else
            {
                Console.WriteLine("Açúcar insuficiente para fazer o cafézinho saboroso");
            }
            Console.WriteLine($"Agora tem {acucarDisponivel}g de açúcar disponível");

        }

        public int MostrarAcucar()
        {
            return acucarDisponivel;
        }



    }
}