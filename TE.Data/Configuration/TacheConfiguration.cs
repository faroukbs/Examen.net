using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TE.Core.Domain;

namespace TE.Data.Configuration
{
    public class TacheConfiguration : IEntityTypeConfiguration<Tache>
    {
        public void Configure(EntityTypeBuilder<Tache> builder)
        {
            
            builder.HasOne(e => e.Sprint).WithMany(e => e.Taches).HasForeignKey(e=>e.SprintKey);
            builder.HasOne(e => e.Member).WithMany(e => e.Taches).HasForeignKey(e=>e.MemberKey);
        }
    }
}
