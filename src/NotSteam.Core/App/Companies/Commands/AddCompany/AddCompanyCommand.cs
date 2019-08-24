﻿using MediatR;

namespace NotSteam.Core.App.Companies.Commands.AddCompany
{
    public class AddCompanyCommand : IRequest<AddCompanyDto>
    {
        public AddCompanyDto AddCompanyDto { get; set; }
    }
}