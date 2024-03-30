using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Infrastucture.Persistence.Constans;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Configurations;

public sealed class ReportConfiguration : IEntityTypeConfiguration<Report>
{
    public void Configure(EntityTypeBuilder<Report> builder)
    {
        builder.ToTable(TableNames.Reports);
        builder.HasKey(t => t.Id);
    }
}
