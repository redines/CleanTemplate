using MediatR;

namespace Application.Features.Examples
{
    //Message being thrown for mediatR to handle in IRequestHandler
    public class GetExamplesListQuery : IRequest<List<ExampleListVm>>
    {


    }
}
