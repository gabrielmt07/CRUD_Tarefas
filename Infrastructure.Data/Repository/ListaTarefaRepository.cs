using Domain.Interfaces.Datas;
using Domain.Models;
using Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Repository;

public class ListaTarefaRepository : IListaTarefaRepository
{
    private readonly ListaTarefaDbContext _listaTarefaDbContext;

    public ListaTarefaRepository(ListaTarefaDbContext listaTarefaDbContext)
    {
        _listaTarefaDbContext = listaTarefaDbContext;
    }

    public async Task<ICollection<ListaTarefa>> BuscarTodasListasDeTarefaAsync()
    {
        var listaDeTarefas = await _listaTarefaDbContext.Set<ListaTarefa>()
            .AsNoTracking()
            .ToListAsync();

        return listaDeTarefas;
    }

    public async Task AdicionarListaDeTarefasAsync(ListaTarefa listaTarefa)
    {
        await _listaTarefaDbContext.AddAsync(listaTarefa);
        await _listaTarefaDbContext.SaveChangesAsync();
    }

    public void Dispose() => _listaTarefaDbContext.Dispose();
}