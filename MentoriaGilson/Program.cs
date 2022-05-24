using System;

namespace MentoriaGilson
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuNome = "Gilson"; // declarei uma string -> "PRONUNCIA": meu nome recebe Gilson
           string meuSegundoNome = "Ravaiani"; // outra maneira de declarar uma variável
           string meuNomeCompleto = meuNome + " " + meuSegundoNome; //concatenação
           var mensagemBoasVindas = ($"Olá, meu nome é: {meuNome}"); //Outro modo de concatenar


            //"" -> varios caracteres
            //'' -> Apenas um caracter
                       
            Console.WriteLine(meuNomeCompleto);
            Console.WriteLine(meuNome + meuSegundoNome);
            Console.WriteLine(mensagemBoasVindas);
        }
    }
}
