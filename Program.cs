using System;

namespace amor_e_odio
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando as variaveis
            string amor = "Amor";
            string odio = "odio";
            string amorguardado; //Variavel

            //escrevendo na tela o conteudo de amor e te ódio
            amorguardado = amor;
            amor = odio;
            odio = amorguardado;

            Console.WriteLine($"Conteúdo da variavel amor: {amor}");
            Console.WriteLine($"Conteúdo da variavel odio: {odio}");

        }
    }
}
