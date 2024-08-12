using FluentValidation;
using StockAnalyzeApp.Core.Dto.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Validator.OrderValidators
{
    public class OrderDtoValidator:AbstractValidator<OrderDto>
    {
        public OrderDtoValidator()
        {
            RuleFor(x => x.Quantity).GreaterThan(0).NotEmpty().WithMessage("Quantity must not be Empty");
            RuleFor(x => x.Price).GreaterThan(0).NotEmpty().WithMessage("Price must not be Empty");
            RuleFor(x => x.OrderCode).NotEmpty().WithMessage("OrderCode must not be Empty");
        }
    }
}
