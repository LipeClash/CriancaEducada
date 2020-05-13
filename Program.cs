using System;

namespace CriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa:");
            Console.Write("Eu acho que é um boboca, e que vai ficar palerma pra sempre.");

            String CriançaEducada = Console.ReadLine();
            String Substituíra = Console.ReadLine();

            Console.WriteLine(CriançaEducada + " " + Substituíra);
        }
    }
}
