using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0, d = 0;
            string res = "";
            bool verifica = false;
            List<string> nomes  = new List<string>();
            do{
                Console.Clear();
                Console.Write($"Cadastrar pessoas\nDigite o {c+1}º nome: ");
                nomes.Add(Console.ReadLine());
                c++;
                Console.Write("\nCadastrar outro? [S/N] ");
                res = Console.ReadLine().ToUpper();
                verifica = res == "S" ? false : true;
            }while(verifica == false);
            Console.Clear();
            Console.WriteLine("=== Cadastros ===\nCódigo Nome");
            foreach(string nome in nomes){
                Console.WriteLine($"[ {d+1} ]  {nomes[d]}");
                d++;
            }
        }
    }
}