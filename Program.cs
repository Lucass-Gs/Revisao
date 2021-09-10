using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {   
            string opcaoUsuario = new ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X"){
                
                switch(opcaoUsuario){

                    case: "1":

                        break;                        
                    case: "2":

                        break;

                    case: "3":

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();            

                }                         

                opcaoUsuario = ObterOpcaoUsuario();

            }

        }

        private static string ObterOpcaoUsuario(){

            Console.WriteLine("Informe a opcao desejada:");
            Console.WriteLine("1 - Inserir novo aluno:");
            Console.WriteLine("2 - Listar alunos:");
            Console.WriteLine("3 - Calcular media geral:");
            Console.WriteLine("X - Sair:");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
