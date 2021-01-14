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
        }
    }
}
