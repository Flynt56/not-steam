using System.ComponentModel.DataAnnotations;

namespace NotSteam.Shared.Pagination
{
    public class PagingRequest
    {
        [Range(0, int.MaxValue)]
        public int Page { get; set; } = 1;

        [Range(0, 200)]
        public int PageSize { get; set; } = 10;
    }
}
