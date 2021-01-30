using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(e => e.TC_KimlikNo).NotEmpty().WithMessage("T.C.Kimlik Numarası boş bırakılamaz.T.C.Kimlik Numarası zorunludur.");
            RuleFor(e => e.sicil_no).NotEmpty();
            RuleFor(e => e.SurName).NotEmpty();
            RuleFor(e => e.Name).NotEmpty();
            RuleFor(e => e.sicil_no).Must(StartWithAB);
        }

        private bool StartWithAB(string arg)
        {
            return arg.StartsWith("ab");
        }
    }
}
