using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineMuhasebeServer.Domain.CompanyEntites;
using OnlineMuhasebeServer.Infrastucture.Persistence.Constans;

namespace OnlineMuhasebeServer.Infrastucture.Persistence.Configurations;
public sealed class BookEntryConfiguration : IEntityTypeConfiguration<BookEntry>
{
    public void Configure(EntityTypeBuilder<BookEntry> builder)
    {
        builder.ToTable(TableNames.BookEntries);
        builder.HasKey(t => t.Id);
    }
}
