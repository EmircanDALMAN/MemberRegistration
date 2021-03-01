using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Constants;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MemberValidator : AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty().WithMessage(Messages.FirstNameNotEmpty);
            RuleFor(m => m.LastName).NotEmpty().WithMessage(Messages.LastNameNotEmpty);
            RuleFor(m => m.Email).NotEmpty().WithMessage(Messages.EmailNotEmpty);
            RuleFor(m => m.TcNo).NotEmpty().WithMessage(Messages.TcNoNotEmpty);
            RuleFor(m => m.DateOfBirth).NotEmpty().WithMessage(Messages.DateOfBirthNotEmpty);
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now).WithMessage(Messages.DateOfBirthLessThanDatetimeNow);
            RuleFor(m => m.Email).EmailAddress().WithMessage(Messages.ErrorEmailAddressFormat);
            RuleFor(m => m.TcNo).Length(11).WithMessage(Messages.TcNoLengthError);
        }
    }
}
