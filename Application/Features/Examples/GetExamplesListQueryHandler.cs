using Application.Contracts.Persistance;
using AutoMapper;
using MediatR;

namespace Application.Features.Examples
{
    //Handler will contain the actual behaviour and execute through a request and return the Vm with wanted data
    public class GetExamplesListQueryHandler : IRequestHandler<GetExamplesListQuery,List<ExampleListVm>>
    {
        private readonly IAsyncRepository<ExampleListVm> _exampleListVmRepository;
        private readonly IMapper _mapper;

        public GetExamplesListQueryHandler(IAsyncRepository<ExampleListVm> exampleListVmRepository, IMapper mapper)
        {
            _exampleListVmRepository = exampleListVmRepository;
            _mapper = mapper;
        }

        public async Task<List<ExampleListVm>> Handle(GetExamplesListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _exampleListVmRepository.ListAllAsync()).OrderBy(x => x.ExampleName);
            return _mapper.Map<List<ExampleListVm>>(allEvents);
        }
    }
}
