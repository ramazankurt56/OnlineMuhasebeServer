using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppUserFeatures.Commands.CreateMainRoleAppUser;

public sealed class CreateMainRoleAppUserCommandValidator : AbstractValidator<CreateMainRoleAppUserCommand>
{
    public CreateMainRoleAppUserCommandValidator()
    {
        RuleFor(p => p.UserId).NotEmpty().WithMessage("Kullanıcı seçmelisiniz!");
        RuleFor(p => p.UserId).NotNull().WithMessage("Kullanıcı seçmelisiniz!");
        RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket seçmelisiniz!");
        RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket seçmelisiniz!");
        RuleFor(p => p.MainRoleId).NotEmpty().WithMessage("Rol seçmelisiniz!");
        RuleFor(p => p.MainRoleId).NotNull().WithMessage("Rol seçmelisiniz!");
    }
}
