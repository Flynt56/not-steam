﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using NotSteam.Model.Attributes;
using NotSteam.Model.Identity.Models;

namespace NotSteam.Model.Entities
{
    public class Purchase : ModelBase
    {
        public int UserId { get; set; }
        public int GameId { get; set; }

        [DataType(DataType.Date)]
        [CustomRequired]
        [CustomDateRange]
        public DateTime DateOfPurchase { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Currency)]
        [CustomRequired]
        [CustomRange(0.0, 99.99)]
        [Column(TypeName = "decimal(19,4)")]
        public decimal TotalPrice { get; set; }

        public ApplicationUser User { get; set; }
        public Game Game { get; set; }
    }
}
