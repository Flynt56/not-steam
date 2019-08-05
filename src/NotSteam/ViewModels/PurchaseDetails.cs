using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class PurchaseDetails
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public static Expression<Func<Purchase, PurchaseDetails>> Projection
        {
            get
            {
                return purchase => new PurchaseDetails
                {
                };
            }
        }

        public static PurchaseDetails Create(Purchase purchase)
        {
            return Projection.Compile().Invoke(purchase);
        }
    }
}
