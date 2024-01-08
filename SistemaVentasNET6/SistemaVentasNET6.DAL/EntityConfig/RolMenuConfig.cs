using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentasNET6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.DAL.EntityConfig
{
    public class RolMenuConfig : IEntityTypeConfiguration<RolMenu>
    {
        public void Configure(EntityTypeBuilder<RolMenu> builder)
        {
            builder.HasKey(prop => prop.IdRolMenu);

            builder.HasOne(rm => rm.Rol)
            .WithMany(r => r.RolesMenus)
            .HasForeignKey(rm => rm.IdRol);

            builder.HasOne(rm => rm.Menu)
            .WithMany(m => m.RolesMenus)
            .HasForeignKey(rm => rm.IdMenu);
        }
    }
}
