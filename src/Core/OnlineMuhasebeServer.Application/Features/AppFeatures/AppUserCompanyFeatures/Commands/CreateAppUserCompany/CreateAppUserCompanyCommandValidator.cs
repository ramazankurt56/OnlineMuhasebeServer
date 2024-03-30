using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AppUserCompanyFeatures.Commands.CreateAppUserCompany;


public sealed class CreateAppUserCompanyCommandValidator : AbstractValidator<CreateAppUserCompanyCommand>
{
    public CreateAppUserCompanyCommandValidator()
    {
        RuleFor(p => p.AppUserId).NotEmpty().WithMessage("Kullanıcı seçilmelidir!");
        RuleFor(p => p.AppUserId).NotNull().WithMessage("Kullanıcı seçilmelidir!");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket seçilmelidir!");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket seçilmelidir!");
    }
}
