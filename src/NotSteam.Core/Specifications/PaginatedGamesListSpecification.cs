using NotSteam.Model.Models;

namespace NotSteam.Core.Specifications
{
    public class PaginatedGamesListSpecification : BaseSpecification<Game>
    {
        public PaginatedGamesListSpecification(int skip, int take, int? companyId)
            : base(e => (!companyId.HasValue || e.CompanyId == companyId))
        {
            AddInclude(e => e.Company);
            ApplyPaging(skip, take);
        }
    }
}
