using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using OnlineMuhasebeServer.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OnlineMuhasebeServer.Domain.Dtos;
using OnlineMuhasebeServer.Presentation.Controllers;
namespace OnlineMuhasebeServer.UnitTest.Features.AppFeatures.CompanyFeatures;
public sealed class CreateCompanyCommandUnitTest
{
    [Fact]
    public async Task  Create_ReturnsOkResult_WhenRequestIsValid()
    {
        //Arrange
        var mediatorMock = new Mock<IMediator>();
        CreateCompanyCommand createCompanyCommand = new(
            Name: "Saydam Ltd Şti",
           ServerName: "localhost",
           DatabaseName: "SaydamMuhasebeDb",
           UserId: "",
           Password: "");
        MessageResponse response = new("Araç Başarıyla Kaydedildi!");
        CancellationToken cancellationToken = new();
        mediatorMock.Setup(m => m.Send(createCompanyCommand, cancellationToken)).ReturnsAsync(response);
        CompaniesController companiesController = new(mediatorMock.Object);

        //Act
        var result = await companiesController.CreateCompany(createCompanyCommand, cancellationToken);

        //Assert
        var okResult = Assert.IsType<OkObjectResult>(result);
        var returnValue = Assert.IsType<MessageResponse>(okResult.Value);
        Assert.Equal(response, returnValue);
        mediatorMock.Verify(m => m.Send(createCompanyCommand, cancellationToken), Times.Once);
    }
}