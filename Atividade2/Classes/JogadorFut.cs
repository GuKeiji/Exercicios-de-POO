using System;

namespace Atividade2.Classes
{
    public abstract class JogadorFut
    {
        public string nome;
        public int anoNascimento;
        public string nacionalidade;
        public float altura;
        public int peso;
        // Lembrar de fazer método da idade, retornar a idade e igualar com a var idade
        public int CalcularIdade(int anoNascimento)
        {
            int idade = DateTime.Now.Year - anoNascimento;
            return idade;
        }
        public void MostrarDados(string nome, int anoNascimento, string nacionalidade, float altura, int peso, int idade)
        {
            Console.WriteLine($@"Nome:{nome}
Ano de nascimento:{anoNascimento}
Nacionalidade:{nacionalidade}
Altura:{altura}
Peso:{peso}    
Idade:{idade}       
            ");
        }
        public virtual void Aposentar(int idade, string nome)
        {
            if (idade < 40)
            {
                Console.WriteLine($"{nome} vai se aposentar com 40 anos, daqui {40 - idade} anos");
            }
            else
            {
                Console.WriteLine($"{nome} pode se aposentar");
            }
        }
    }
}