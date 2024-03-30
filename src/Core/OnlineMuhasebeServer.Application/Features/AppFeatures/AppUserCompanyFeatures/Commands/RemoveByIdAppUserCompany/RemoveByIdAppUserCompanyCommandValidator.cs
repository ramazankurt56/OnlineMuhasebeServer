using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AppUserCompanyFeatures.Commands.RemoveByIdAppUserCompany;

public sealed class RemoveByIdAppUserCompanyCommandValidator: AbstractValidator<RemoveByIdAppUserCompanyCommand>
{
    public RemoveByIdAppUserCompanyCommandValidator()
    {
        RuleFor(p=> p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
        RuleFor(p=> p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
    }
}
