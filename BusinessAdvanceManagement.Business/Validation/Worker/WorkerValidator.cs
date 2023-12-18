using BusinessAdvanceManagement.Core.MagicStrings;
using BusinessAdvanceManagement.Domain.DTOs.Worker;
using BusinessAdvanceManagement.Domain.ViewModel.Worker;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Business.Validation.Worker
{
    public class WorkerValidator : AbstractValidator<WorkerRegistrationVM>
    {
        public WorkerValidator()
        {
            RuleFor(w => w.WorkerAddUserDTO.WorkerAddDTO.WorkerName)
                .NotEmpty().WithMessage(MagicStrings.workerNameNotNull)
                .Must(name => !string.IsNullOrWhiteSpace(name)).WithMessage(MagicStrings.workerNameNotNull);

            RuleFor(w => w.WorkerAddUserDTO.WorkerAddDTO.WorkerSurname)
                .NotEmpty().WithMessage(MagicStrings.surnameNotNull)
                .Must(name => !string.IsNullOrWhiteSpace(name)).WithMessage(MagicStrings.surnameNotNull);

            RuleFor(w => w.WorkerAddUserDTO.Password)
                .NotEmpty().WithMessage(MagicStrings.passwordNotNull)
                .Must(password => !string.IsNullOrWhiteSpace(password)).WithMessage(MagicStrings.passwordNotNull);

            RuleFor(w => w.WorkerAddUserDTO.WorkerAddDTO.WorkerBirimID)
                .NotEmpty().WithMessage(MagicStrings.surnameNotNull)
                .Must(BeValidWorkerID).WithMessage(MagicStrings.birimCheckedNull);

            RuleFor(w => w.WorkerAddUserDTO.WorkerAddDTO.WorkerRolID)
                .NotEmpty().WithMessage(MagicStrings.RoleNotNull)
                .Must(BeValidWorkerID).WithMessage(MagicStrings.RoleNotNull);

            RuleFor(w => w.WorkerAddUserDTO.WorkerAddDTO.WorkerManagerID)
                .NotEmpty().WithMessage(MagicStrings.managerNotNull)
                .Must(BeValidWorkerID).WithMessage(MagicStrings.managerNotNull);


            RuleFor(w => w.WorkerAddUserDTO.WorkerAddDTO.WorkerEmail)
                .NotEmpty().WithMessage(MagicStrings.emailNotNull)
                .Must(email => !string.IsNullOrWhiteSpace(email)).WithMessage(MagicStrings.emailNotNull)
                .EmailAddress().WithMessage(MagicStrings.notEmailFormat);
        }
        private bool BeValidWorkerID(int workerID)
        {
            
            return workerID != 0;
        }
    }
}
