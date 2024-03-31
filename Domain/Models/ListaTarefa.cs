namespace Domain.Models;

public class ListaTarefa
{
    public int Id { get; private set; }
    public string? Responsavel { get; private set; }
    public ICollection<Tarefa>? Tarefas { get; private set; }
}