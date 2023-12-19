using BusinessAdvanceManagement.Domain.ViewModel.AdvanceRequest;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Business.Validation.AdvanceRequest
{
    public class AdvanceRequestValidator : AbstractValidator<AdvanceRequestVM>
    {
        public AdvanceRequestValidator()
        {
            RuleFor(x => x.AdvanceRequestAddDTO.Amount)
            .NotEmpty().WithMessage("talep tutarı boş geçilemez");

            RuleFor(x => x.AdvanceRequestAddDTO.Amount)
            .Must(BeValidNumber).WithMessage("Talep tutarı bir sayı veya ondalık sayı olmalıdır.");

            RuleFor(x => x.AdvanceRequestAddDTO.DesiredDate)
            .NotEmpty().WithMessage("Tarih boş olamaz.");

            RuleFor(x => x.AdvanceRequestAddDTO.ProjectID)
           .NotEmpty().WithMessage("Proje boş olamaz.")
           .Must(BeValidWorkerID).WithMessage("Proje seçilmeli"); 

            RuleFor(x => x.AdvanceRequestAddDTO.Description)
            .NotEmpty().WithMessage("Açıklama boş olamaz.")
            .Must(BeNotNullOrWhitespace).WithMessage("Değer null veya boşluklardan oluşamaz.");
        }
        private bool BeValidNumber(decimal confirmAmount)
        {
            string confirmAmountString = confirmAmount.ToString();
            return !string.IsNullOrWhiteSpace(confirmAmountString) && confirmAmountString.All(char.IsDigit);
        }
        private bool BeNotNullOrWhitespace(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }
        private bool BeValidWorkerID(int workerID)
        {

            return workerID != 0;
        }
    }
}
