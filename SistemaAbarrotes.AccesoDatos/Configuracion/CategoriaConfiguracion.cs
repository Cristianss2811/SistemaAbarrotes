﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaAbarrotes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAbarrotes.AccesoDatos.Configuracion
{
    public class CategoriaConfiguracion
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Nombre).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Descripcion).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Estado).IsRequired();

        }
    }
}
