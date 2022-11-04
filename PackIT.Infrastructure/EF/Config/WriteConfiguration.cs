using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PackIT.Application.Commands;
using PackIT.Domain.Entities;

namespace PackIT.Infrastructure.EF.Config;

internal sealed class WriteConfiguration :
    IEntityTypeConfiguration<PackingList>,
    IEntityTypeConfiguration<PackItem>
{
    public void Configure(EntityTypeBuilder<PackingList> builder)
    {
        builder.HasKey(pl => pl.Id);
    }

    public void Configure(EntityTypeBuilder<PackItem> builder)
    {
        throw new NotImplementedException();
    }
}