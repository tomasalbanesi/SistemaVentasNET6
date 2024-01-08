using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaVentasNET6.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasNET6.DAL.EntityConfig
{
    internal class ConfiguracionConfig : IEntityTypeConfiguration<Configuracion>
    {
        public void Configure(EntityTypeBuilder<Configuracion> builder)
        {
            builder.HasKey(prop => prop.Propiedad);
        }
    }
}
