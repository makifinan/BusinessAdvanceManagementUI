using BusinessAdvanceManagement.Domain.DTOs.RequestDetail;
using BusinessAdvanceManagement.Domain.ViewModel.RequestDetail;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAdvanceManagement.Business.Validation.RequestDetail
{
    public class RequestDetailValidator : AbstractValidator<PendingApprovalDetailPageVM>
    {
        public RequestDetailValidator()
        {
            RuleFor(x => x.RequestDetailAddDTO.ConfirmAmount)
            .NotEmpty().WithMessage("Değer boş olamaz.");

            RuleFor(x => x.RequestDetailAddDTO.ConfirmAmount)
            .Must(BeValidNumber).WithMessage("Onaylanan miktar bir sayı veya ondalık sayı olmalıdır.");



           // RuleFor(x => x.RequestDetailAddDTO.DeterminedPaymentDate)
           //.NotEmpty().WithMessage("Tarih boş olamaz.");

           // RuleFor(x => x.RequestDetailAddDTO.AdvanceReceiptNumber)
           // .NotEmpty().WithMessage("Değer boş olamaz.")
           // .Must(BeNotNullOrWhitespace).WithMessage("Değer null veya boşluklardan oluşamaz.");

        }

        private bool BeValidNumber(int confirmAmount)
        {
            string confirmAmountString = confirmAmount.ToString();
            return !string.IsNullOrWhiteSpace(confirmAmountString) && confirmAmountString.All(char.IsDigit);
        }
        private bool BeNotNullOrWhitespace(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }


    }
}
