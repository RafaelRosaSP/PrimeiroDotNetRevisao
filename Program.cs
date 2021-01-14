using System;

namespace PrimeiroDotNetRev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- alcular média geral");
            Console.WriteLine("4 X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    //TO DO: adcionar alundo

                        break;
                    case "2":
                    //TO DO: listar alunos
                        break;
                    case "3
                    //TO DO: calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            
        }
    }
}
