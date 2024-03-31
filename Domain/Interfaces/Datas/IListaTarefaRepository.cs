using Domain.Models;

namespace Domain.Interfaces.Datas;

public interface IListaTarefaRepository : IDisposable
{
    Task<ICollection<ListaTarefa>> BuscarTodasListasDeTarefaAsync();
    Task AdicionarListaDeTarefasAsync(ListaTarefa listaTarefa);
}