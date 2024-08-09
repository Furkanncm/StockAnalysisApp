using FluentValidation;
using StockAnalyzeApp.Core.Dto.UserDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Validator.UserValidators
{
    public class UserAddDtoValidators:AbstractValidator<UserAddDto>
    {
        public UserAddDtoValidators() { 

            RuleFor(x=>x.FirstName).NotEmpty().WithMessage("FirstName must be not Empty");
            RuleFor(x=>x.LastName).NotEmpty().WithMessage("LastName must be not Empty");
            RuleFor(x=>x.Address).NotEmpty().WithMessage("Address must be not Empty");
            RuleFor(x=>x.Password).NotEmpty().WithMessage("Password must be not Empty");
            RuleFor(x=>x.UserCode).NotEmpty().WithMessage("UserCode must be not Empty");
            RuleFor(x=>x.CompanyId).NotEmpty().WithMessage("CompanyId must be not Empty");


        }
    }
}
