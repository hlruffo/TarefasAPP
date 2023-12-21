using AutoMapper;
using TarefasApp.Domain.Entities;
using TarefasApp.Services.Models;

namespace TarefasApp.Services.Mappings
{
    public class AutoMapperConfig :Profile

    {
        public AutoMapperConfig()
        {
            CreateMap<TarefasPostModel, Tarefa>()
                .AfterMap((model, entity) =>
                {
                    entity.Id = Guid.NewGuid();
                }
            );
        }
    }
}
