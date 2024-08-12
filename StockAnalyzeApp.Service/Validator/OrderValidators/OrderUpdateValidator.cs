using FluentValidation;
using StockAnalyzeApp.Core.Dto.OrderDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Validator.OrderValidators
{
    public class OrderUpdateValidator:AbstractValidator<OrderUpdateDto>
    {
        public OrderUpdateValidator()
        {
            RuleFor(x => x.Id).GreaterThan(0).NotEmpty().WithMessage("Id must not be Empty");
            RuleFor(x => x.Quantity).GreaterThan(0).NotEmpty().WithMessage("Quantity must not be Empty");
            RuleFor(x => x.Price).GreaterThan(0).NotEmpty().WithMessage("Price must not be Empty");
            RuleFor(x => x.OrderCode).NotEmpty().WithMessage("OrderCode must not be Empty");
            RuleFor(x => x.UserId).NotEmpty().WithMessage("UserID must not be Empty");
        }
    }
}
