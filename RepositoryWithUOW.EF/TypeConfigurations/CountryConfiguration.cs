using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RepositoryWithUOW.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOW.EF.TypeConfigurations
{
    internal class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            var cl = new List<Country>();
            for (int i = 1; i <= 100; i++)
            {
                cl.Add(new()
                {
                    Id = i,
                    Name = $"Country{i}"
                });
            }
            builder.HasData(cl);
        }
    }
}
