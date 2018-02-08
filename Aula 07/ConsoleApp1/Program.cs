using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static CadeMeuMedicoEntities db;

        static void Main(string[] args)
        {
            db = new CadeMeuMedicoEntities();

            Console.WriteLine("Nome da cidade?");
            var nomeCidade = Console.ReadLine();

            InserirCidade(nomeCidade);

            Console.WriteLine($"{nomeCidade} adicionado com sucesso");
        }

        public static void InserirCidade(string nome)
        {
            var novaCidade = new Cidade();
            novaCidade.Nome = nome;

            db.Cidades.Add(novaCidade);

            db.SaveChanges();
        }
    }
}
