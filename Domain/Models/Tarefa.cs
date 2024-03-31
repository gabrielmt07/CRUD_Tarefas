using Domain.Models.Enums;

namespace Domain.Models;

public class Tarefa
{
    public int Id { get; private set; }
    public string? Nome { get; private set; }
    public Status Status { get; private set; }
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }
    public ListaTarefa? ListaTarefa { get; private set; }

    public void SetDataAtualizacao(DateTime dataAtualizacao) =>
        DataAtualizacao = dataAtualizacao;

    public void SetStatus(Status status) =>
        Status = status;
}