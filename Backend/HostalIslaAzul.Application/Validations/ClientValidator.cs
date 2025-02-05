using FluentValidation;
using HostalIslaAzul.Domain.Entities;

namespace HostalIslaAzul.Application.Validations;
public class ClientValidator : AbstractValidator<Client>
{
    public ClientValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("El nombre es requerido")
            .MinimumLength(2).WithMessage("Nombre muy corto")
            .MaximumLength(50).WithMessage("Nombre muy largo");

        RuleFor(x => x.CI)
            .NotEmpty().WithMessage("CI es requerido")
            .Matches(@"^\d{11}$").WithMessage("CI debe tener 11 dígitos");

        RuleFor(x => x.PhoneNumber)
            .NotEmpty().WithMessage("Teléfono es requerido")
            .Matches(@"^\+?(\d{10,12})$").WithMessage("Formato de teléfono inválido");
    }
}