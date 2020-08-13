using Interparking.Users.Api.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interparking.Users.Api.Infrastructure.EntityConfiguration
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(m => m.Email);

            builder.Property(m => m.ID)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(m => m.Name)
                .HasColumnName("Name")
                .IsRequired();

            builder.Property(m => m.Email)
                .HasColumnName("Email")
                .IsRequired();

            builder.Property(m => m.Salt)
                .HasColumnName("Salt")
                .IsRequired();

            builder.Property(m => m.HashedPassword)
                .HasColumnName("HashedPassword")
                .IsRequired();
        }
    }
}
