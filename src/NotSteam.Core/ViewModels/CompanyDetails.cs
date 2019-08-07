using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class CompanyDetails
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<string> GameNames { get; set; } = new HashSet<string>();

        public static Expression<Func<Company, CompanyDetails>> Projection
        {
            get
            {
                return company => new CompanyDetails
                {
                    Name = company.Name,
                    Description = company.Description,
                    GameNames = company.Games.Select(g => g.Title).ToHashSet()
                };
            }
        }

        public static CompanyDetails Create(Company company)
        {
            return Projection.Compile().Invoke(company);
        }
    }
}
