using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_EF02.Model
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {    
        public void Configure(EntityTypeBuilder<Event> builder)
        {
         builder.HasKey(E => E.EventID);
         builder.Property(E => E.EventID).UseIdentityColumn(10, 10);
         builder.Property (E => E.Title).IsRequired().HasMaxLength (200);
         builder.Property(E => E.Description).IsRequired();
            builder.Property(E => E.StartDate).HasDefaultValueSql("GETDATE()");

         builder.Property<DateTime>("CreatedAt").HasDefaultValueSql("GETDATE()");
         builder.Property<DateTime>("LastModified");
         
        

        }
    }


}
