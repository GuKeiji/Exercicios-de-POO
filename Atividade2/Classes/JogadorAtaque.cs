using System;

namespace Atividade2.Classes
{
    public class JogadorAtaque:JogadorFut
    {
        public override void Aposentar(int idade, string nome)
        {
            if (idade < 35)
            {
                Console.WriteLine($"{nome} vai se aposentar com 35 anos, daqui {35 - idade} anos");
            }
            else
            {
                Console.WriteLine($"{nome} pode se aposentar");
            }
        }
    }
}