using Commpay.Models;
using System.ComponentModel.DataAnnotations;

namespace Commpay.CustomAttributes
{
    public class CPFValidator : ValidationAttribute
    {

        public string GetErrorMessage() =>
            $"O CPF informado é inválido";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            //var usuario = (Usuario)validationContext.ObjectInstance;
            var CPF = value!.ToString();

            if (CPF == null && !Utils.Utils.ValidaCPF(CPF))
            {
                return new ValidationResult(GetErrorMessage());
            }

            return ValidationResult.Success;
        }

    }
}
