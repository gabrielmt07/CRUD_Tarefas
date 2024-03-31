using Domain.DTO;
using Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Tarefas.Controllers;

[ApiController]
[Route("api")]
public class ListaTarefaController : ControllerBase
{
    private readonly IListaTarefaService _listaTarefaService;

    public ListaTarefaController(IListaTarefaService listaTarefaService)
    {
        _listaTarefaService = listaTarefaService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var listaDeTarefas = await _listaTarefaService.BuscarTodasListasDeTarefaAsync();

        return Ok(listaDeTarefas);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] ListaTarefaDto listaTarefaDto)
    {
        await _listaTarefaService.AdicionarListaDeTarefasAsync(listaTarefaDto);

        return Created();
    }
}