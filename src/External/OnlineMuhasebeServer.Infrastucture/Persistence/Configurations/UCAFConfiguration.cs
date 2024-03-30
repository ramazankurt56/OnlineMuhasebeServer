using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Infrastucture.Persistence.Constans;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Configurations;
public sealed class UCAFConfiguration : IEntityTypeConfiguration<UniformChartOfAccount>
{
    public void Configure(EntityTypeBuilder<UniformChartOfAccount> builder)
    {
        builder.ToTable(TableNames.UniformChartOfAccounts);
        builder.HasKey(p => p.Id);
    }

}