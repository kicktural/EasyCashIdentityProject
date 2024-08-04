using EasyCashIdentityProject.Dto.Layer.Dtos.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.Business.Layer.ValidationRules.AppUserValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDto>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be left empty!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Surname field cannot be left blank!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Username field cannot be left blank!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email field cannot be left blank!");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password field cannot be left blank!");
            RuleFor(x => x.ConfirmPassord).NotEmpty().WithMessage("ConfirmPassword field cannot be left blank!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Please enter at least 30 characters");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Please enter at least two characters!");
            RuleFor(x => x.ConfirmPassord).Equal(x => x.Password).WithMessage("Your passwords do not match");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Please add a valid email address");
        }
    }
}
