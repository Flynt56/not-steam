﻿using MediatR;

namespace NotSteam.Core.App.Companies.Commands.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest
    {
        public int Id { get; set; }
    }
}