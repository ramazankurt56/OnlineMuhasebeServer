using FluentValidation;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleAppRoleFeatures.Commands.CreateMainRoleAppRole;

public sealed class CreateMainRoleAppRoleCommandValidator : AbstractValidator<CreateMainRoleAppRoleCommand>
{
	public CreateMainRoleAppRoleCommandValidator()
	{
		RuleFor(p=> p.RoleId).NotEmpty().WithMessage("Rol seçilmelidir!");
		RuleFor(p=> p.RoleId).NotNull().WithMessage("Rol seçilmelidir!");
		RuleFor(p=> p.MainRoleId).NotNull().WithMessage("Ana Rol seçilmelidir!");
		RuleFor(p=> p.MainRoleId).NotEmpty().WithMessage("Ana Rol seçilmelidir!");
	}
}
