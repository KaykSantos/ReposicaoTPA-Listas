using System;

namespace TPA_Listas
{
    class Desafio
    {
        static void Main(string[] args)
        {
            int c = 0, d = 0;
            string res = "";
            bool verifica1 = false, verifica2 = false;
            string[] nomes = new string[5];
            do{
                Console.Clear();
                Console.Write($"Cadastrar pessoas\nDigite o {c+1}º nome: ");
                nomes[c] = Console.ReadLine();
                c++;

                Console.Write("\nCadastrar outro? [S/N] ");
                res = Console.ReadLine().ToUpper();
                verifica1 = res == "S" ? false : true;
            }while(verifica1 == false);
            Console.Clear();
            Console.WriteLine("=== Cadastros ===\nCódigo Nome");
            do{
                Console.WriteLine($"[ {d+1} ]  {nomes[d]}");
                d++;
                verifica2 = d == c ? true : false;
            }while(verifica2 == false);
        }
    }
}

