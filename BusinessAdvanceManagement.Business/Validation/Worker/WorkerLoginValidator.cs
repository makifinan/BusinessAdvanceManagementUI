using BusinessAdvanceManagement.Core.MagicStrings;
using BusinessAdvanceManagement.Domain.DTOs.Worker;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Business.Validation.Worker
{
    public class WorkerLoginValidator : AbstractValidator<WorkerLoginDTO>
    {
        public WorkerLoginValidator()
        {
            RuleFor(w => w.Password)
                .NotEmpty().WithMessage(MagicStrings.passwordNotNull)
                .Must(password => !string.IsNullOrWhiteSpace(password)).WithMessage(MagicStrings.passwordNotNull);
            RuleFor(w => w.Email)
                .NotEmpty().WithMessage(MagicStrings.emailNotNull)
                .Must(email => !string.IsNullOrWhiteSpace(email)).WithMessage(MagicStrings.emailNotNull)
                .EmailAddress().WithMessage(MagicStrings.notEmailFormat);
        } 
    }
}
