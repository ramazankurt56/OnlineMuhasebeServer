using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Application.Abstraction;
using OnlineMuhasebeServer.Application.Messaging;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Domain.Entities.Identity;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login;
public class LoginCommandHandler : ICommandHandler<LoginCommand, LoginCommandResponse>
{
    private readonly IJwtProvider _jwtProvider;
    private readonly UserManager<AppUser> _userManager;
    //private readonly IAuthService _authService;
    public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
    {
        _jwtProvider = jwtProvider;
        _userManager = userManager;
        // _authService = authService;
    }

    public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        AppUser user = await _userManager.Users
            .Where(p => p.Email == request.EmailOrUserName || p.UserName == request.EmailOrUserName).FirstOrDefaultAsync();

        if (user == null)
        {
            throw new Exception("Kullanıcı bulunamadı!");
        }
        var checkUser = await _userManager.CheckPasswordAsync(user, request.Password);
        if (!checkUser) throw new Exception("Şifreniz yanlış!");
        //IList<UserAndCompanyRelationship> companies= await _queryRepository.GetWhere(p => p.AppUserId == userId).Include("Company").ToListAsync();
        // IList<UserAndCompanyRelationship> companies = await _authService.GetCompanyListByUserIdAsync(user.Id);
        //IList<CompanyDto> companiesDto = companies.Select(s => new CompanyDto(
        //    s.Company.Id, s.Company.Name)).ToList();

        //if (companies.Count() == 0) throw new Exception("Herhangi bir şikete kayıtlı değilsiniz!");

        //LoginCommandResponse response = new(
        //    Token: await _jwtProvider.CreateTokenAsync(user),
        //    Email: user.Email,
        //    UserId: user.Id,
        //    NameLastName: user.NameLastName,
        //    Companies: companiesDto,
        //    Company: companiesDto[0],
        //    Year: DateTime.Now.Year
        //    );
        List<string> roles = new();
        LoginCommandResponse response = new(
            Token: await _jwtProvider.CreateTokenAsync(user, roles),
            Email: user.Email,
            UserId: user.Id,
            NameLastName: user.NameLastName
            );

        return response;
    }
}