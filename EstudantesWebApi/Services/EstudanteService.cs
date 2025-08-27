using EstudantesWebApi.Models;

namespace EstudantesWebApi.Services
{
    public class EstudanteService : IEstudanteService
    {
        private static List<Estudante> estudantes = new List<Estudante>
        {
            new Estudante { Id = 1, Nome = "Eduardo", Idade = 20 },
            new Estudante { Id = 2, Nome = "Daniele", Idade = 23 },
            new Estudante { Id = 3, Nome = "João", Idade = 21 }
        };

        public List<Estudante> GetAll()
        {
            return estudantes;
        }

        public Estudante Add(Estudante estudante)
        {
            estudante.Id = estudantes.Count + 1;
            estudantes.Add(estudante);
            return estudante;
        }
    }
}
