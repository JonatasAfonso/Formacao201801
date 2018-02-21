using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestDb
{
    class Program
    {
        private static DatabaseExemplo _db;
        static void Main(string[] args)
        {
            _db = new DatabaseExemplo();

            //AdicionarCidade("1234567890 1234567890 1234567890 " +
            //                "1234567890 1234567890 1234567890" +
            //                "1234567890 1234567890 1234567890" +
            //                "1234567890 1234567890 1234567890");

            //var cidades = ObterCidades();

            //foreach (var cidade in cidades)
            //{
            //    Console.WriteLine(cidade.Nome);
            //}

            //AdicionarEspecialidade("Cardiologista");

            //var drArmando = new Medico();
            //drArmando.Cidade = ObterCidadesPorId(1);
            //drArmando.Especialidade = ObterEspecialidadePorId(1);
            //drArmando.NumeroCelula = "12344";
            //drArmando.Nome = "Armando";

            //_db.Medicos.Add(drArmando);


            //var drArtur = new Medico();
            //drArtur.Cidade = ObterCidadesPorId(1);
            //drArtur.Especialidade = ObterEspecialidadePorId(1);
            //drArtur.NumeroCelula = "12244";
            //drArtur.Nome = "drArtur";

            //_db.Medicos.Add(drArtur);

            //_db.SaveChanges();


            ApagarMedicoPorId(1);



            Console.ReadLine();
        }

        public static void AdicionarCidade(string nome)
        {
            var existeCidade = _db.Cidades.Any(x => x.Nome == nome);

            if (!existeCidade)
            {
                var cidade = new Cidade { Nome = nome };

                _db.Cidades.Add(cidade);
                _db.SaveChanges();
            }
        }

        public static void AdicionarEspecialidade(string nome)
        {
            var existeEspecialidade = _db.Especialidades.Any(x => x.Nome == nome);

            if (!existeEspecialidade)
            {
                var especialidade = new Especialidade { Nome = nome };

                _db.Especialidades.Add(especialidade);
                _db.SaveChanges();
            }
        }



        public static List<Cidade> ObterCidades()
        {
            return _db.Cidades.ToList();
        }

        public static Cidade ObterCidadesPorId(int id)
        {
            return _db.Cidades.FirstOrDefault(x => x.Id == id);
        }


        public static Especialidade ObterEspecialidadePorId(int id)
        {
            return _db.Especialidades.FirstOrDefault(x => x.Id == id);
        }

        public static void ApagarMedicoPorId(int id)
        {
            var medico = _db.Medicos.FirstOrDefault(x => x.Id == id);
            _db.Medicos.Remove(medico);
            _db.SaveChanges();
        }

    }
}
