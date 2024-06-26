﻿using OnlineMuhasebeServer.Domain.Dtos;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.AuthFeatures.Commands.Login;
public sealed record LoginCommandResponse(
       TokenRefreshTokenDto Token,
       string Email,
       Guid UserId,
       string NameLastName
      // IList<CompanyDto> Companies,
       //int Year,
      // CompanyDto Company
    );