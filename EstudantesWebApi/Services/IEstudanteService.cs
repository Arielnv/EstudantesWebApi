using EstudantesWebApi.Models;

namespace EstudantesWebApi.Services
{
    public interface IEstudanteService
    {
        List<Estudante> GetAll();
        Estudante Add(Estudante estudante);
    }
}
