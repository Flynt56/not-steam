using MediatR;

namespace NotSteam.Core.App.Tags.Queries.GetTagEditForm
{
    public class GetTagEditFormRequest : IRequest<GetTagEditFormResponse>
    {
        public int Id { get; set; }
    }
}
