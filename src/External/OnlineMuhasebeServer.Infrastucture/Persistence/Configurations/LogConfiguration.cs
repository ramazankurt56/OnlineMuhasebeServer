using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Infrastucture.Persistence.Constans;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Configurations;

public sealed class LogConfiguration : IEntityTypeConfiguration<Log>
{
    public void Configure(EntityTypeBuilder<Log> builder)
    {
        builder.ToTable(TableNames.Logs);
        builder.HasKey(t => t.Id);
    }
}
