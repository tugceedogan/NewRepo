using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Mapping
{
    public class ProfilMap : IEntityTypeConfiguration<Profil>
    {
        public void Configure(EntityTypeBuilder<Profil> builder)
        {
            builder.Property(I => I.Tanim).HasMaxLength(100);
        }
    }
}
