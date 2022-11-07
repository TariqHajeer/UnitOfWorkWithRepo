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
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            var ll = new List<Language>();
            for (int i = 1; i <=100; i++)
            {
                ll.Add(new()
                {
                    Id = i,
                    Name = $"Lang{i}"
                });
            }
            builder.HasData(ll);
        }
    }
}
