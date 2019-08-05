using AutoMapper;
using NotSteam.Infrastructure.AutoMapper.Interfaces;
using NotSteam.Models;
using System;

namespace NotSteam.ViewModels
{
    public class GamesList : IHaveCustomMapping
    {
        public string Name { get; set; }
        public string Nick { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public void CreateMappings(Profile configuration)
        {
        }
    }
}
