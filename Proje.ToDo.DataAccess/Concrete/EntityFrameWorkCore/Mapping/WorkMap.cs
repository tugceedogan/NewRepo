using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Mapping
{
    public class WorkMap : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();
            builder.Property(I => I.Name).HasMaxLength(200);
            builder.Property(I => I.Description).HasColumnType("ntext");
            builder.Property(I => I.Description);
            builder.HasOne(I => I.Aciliyet).WithMany(I => I.Works).HasForeignKey(I=>I.AciliyetId);


        }
    }
}
