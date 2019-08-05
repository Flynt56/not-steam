using System;
using System.Linq.Expressions;
using NotSteam.Models;

namespace NotSteam.ViewModels
{
    public class PurchaseDetails
    {
        public string User { get; set; }
        public string Game { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime Date { get; set; }

        public static Expression<Func<Purchase, PurchaseDetails>> Projection
        {
            get
            {
                return purchase => new PurchaseDetails
                {
                    User = purchase.User.Username,
                    Game = purchase.Game.Title,
                    TotalPrice = purchase.TotalPrice,
                    Date = purchase.DateOfPurchase
                };
            }
        }

        public static PurchaseDetails Create(Purchase purchase)
        {
            return Projection.Compile().Invoke(purchase);
        }
    }
}
