﻿using OnlineMuhasebeServer.Domain.Entities;

namespace OnlineMuhasebeServer.Application.Features.AppFeatures.MainRoleFeatures.Queries.GetAllMainRole;

public sealed record GetAllMainRoleQueryResponse(
    IList<MainRole> MainRoles);
