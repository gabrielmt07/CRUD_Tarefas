using Domain.Models;

namespace Domain.DTO;

public class ListaTarefaDto
{
    public string? Responsavel { get; set; }
    public ICollection<Tarefa>? Tarefas { get; set; }

    public void AddTarefa(Tarefa tarefa)
    {
        if (Tarefas is null)
            Tarefas = new List<Tarefa>();

        Tarefas.Add(tarefa);
    }
}