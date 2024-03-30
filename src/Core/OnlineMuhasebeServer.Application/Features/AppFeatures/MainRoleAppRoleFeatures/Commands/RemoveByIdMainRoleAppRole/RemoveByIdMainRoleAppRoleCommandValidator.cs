using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Commands.RemoveByIdMainRoleAppRole;

public sealed class RemoveByIdMainRoleAppRoleCommandValidator : AbstractValidator<RemoveByIdMainRoleAppRoleCommand>
{
    public RemoveByIdMainRoleAppRoleCommandValidator()
    {
        RuleFor(p => p.Id).NotEmpty().WithMessage("Id alanı zorunludur!");
        RuleFor(p => p.Id).NotNull().WithMessage("Id alanı zorunludur!");
    }
}
