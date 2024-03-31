using AutoMapper;
using Domain.DTO;
using Domain.Models;

namespace Service.Mapper;

public class ListaTarefaMapper : Profile
{
    public ListaTarefaMapper()
    {
        CreateMap<ListaTarefaDto, ListaTarefa>()
            .ReverseMap();
    }
}