using AutoMapper;
using Domain.DTO;
using Domain.Interfaces.Datas;
using Domain.Interfaces.Services;
using Domain.Models;

namespace Service.Services
{
    public class ListaTarefaService : IListaTarefaService
    {
        private readonly IListaTarefaRepository _listaTarefaRepository;
        private readonly IMapper _mapper;

        public ListaTarefaService(IListaTarefaRepository listaTarefaRepository,
                                  IMapper mapper)
        {
            _listaTarefaRepository = listaTarefaRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<ListaTarefaDto>> BuscarTodasListasDeTarefaAsync()
        {
            var listaDeTarefas = await _listaTarefaRepository.BuscarTodasListasDeTarefaAsync();

            return null;
        }

        public async Task AdicionarListaDeTarefasAsync(ListaTarefaDto listaTarefaDto)
        {
            var listaTarefa = _mapper.Map<ListaTarefa>(listaTarefaDto);

            await _listaTarefaRepository.AdicionarListaDeTarefasAsync(listaTarefa);
        }
    }
}