using MediatR;

namespace NotSteam.Core.App.Games.Queries.GetGameEditForm
{
    public class GetGameEditFormRequest : IRequest<GetGameEditFormResponse>
    {
        public int Id { get; set; }
    }
}
