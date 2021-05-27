using System;

namespace Atividade2.Classes
{
    public class JogadorMC:JogadorFut
    {
        public override void Aposentar(int idade, string nome)
        {
            if (idade <  38)
            {
                Console.WriteLine($"{nome} vai se aposentar com 38 anos, daqui {38 - idade} anos");
            }
            else
            {
                Console.WriteLine($"{nome} pode se aposentar");
            }
        }
    }
}