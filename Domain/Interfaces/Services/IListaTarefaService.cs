using Domain.DTO;

namespace Domain.Interfaces.Services;

public interface IListaTarefaService
{
    Task<ICollection<ListaTarefaDto>> BuscarTodasListasDeTarefaAsync();
    Task AdicionarListaDeTarefasAsync(ListaTarefaDto listaTarefa);
}