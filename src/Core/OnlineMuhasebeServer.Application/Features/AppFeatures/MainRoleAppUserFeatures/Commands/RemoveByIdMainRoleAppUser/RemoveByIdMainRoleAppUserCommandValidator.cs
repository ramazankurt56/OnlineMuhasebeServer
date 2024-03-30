using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppUserFeatures.Commands.RemoveByIdMainRoleAppUser;

public sealed class RemoveByIdMainRoleAppUserCommandValidator: AbstractValidator<RemoveByIdMainRoleAppUserCommand>
{
    public RemoveByIdMainRoleAppUserCommandValidator()
    {
        RuleFor(p=> p.Id).NotEmpty().WithMessage("Id alanı boş olamaz!");
        RuleFor(p=> p.Id).NotNull().WithMessage("Id alanı boş olamaz!");
    }
}
