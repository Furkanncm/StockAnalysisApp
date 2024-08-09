using FluentValidation;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Validator.StockValidators
{
    public class StockAddDtoValidator : AbstractValidator<StockAddDto>
    {
        public StockAddDtoValidator()
        {
            RuleFor(x => x.StockCode).NotEmpty().WithMessage("StockCode Code must not be empty");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserId Name must not be empty");
            RuleFor(x => x.Quantity).NotEmpty().WithMessage("Quantity must not be empty").GreaterThan(0).WithMessage("Quantity must not equals to 0");
            RuleFor(x => x.Type).NotEmpty().WithMessage("Type must not be empty");
        }
    }
}
