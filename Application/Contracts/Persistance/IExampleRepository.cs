using Domain.Entities;

namespace Application.Contracts.Persistance
{
    internal interface IExampleRepository : IAsyncRepository<ExampleEntity>
    {
    }
}
