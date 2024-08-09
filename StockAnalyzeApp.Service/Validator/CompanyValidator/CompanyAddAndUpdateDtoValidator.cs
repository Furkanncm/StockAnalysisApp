using FluentValidation;
using StockAnalyzeApp.Core.Dto.CompanyDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Validator.CompanyValidator
{
    public class CompanyAddAndUpdateDtoValidator:AbstractValidator<CompanyAddDto>
    {
        public CompanyAddAndUpdateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address cannot be empty");
        }
    }
}
