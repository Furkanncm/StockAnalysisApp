using FluentValidation;
using StockAnalyzeApp.Core.Dto.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Validator.OrderValidators
{
    public class OrderAddDtoValidator:AbstractValidator<OrderAddDto>
    {
        public OrderAddDtoValidator()
        {
            RuleFor(x => x.Quantity).GreaterThan(0).NotEmpty();
            RuleFor(x => x.Price).GreaterThan(0).NotEmpty();
            RuleFor(x => x.OrderCode).GreaterThan(0).NotEmpty();
            RuleFor(x => x.UserId).NotEmpty();
        }
    }
}
