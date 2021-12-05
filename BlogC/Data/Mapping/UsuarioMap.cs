using BlogC.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogC.Data.Mapping
{
    public class UsuarioMap: IEntityTypeConfiguration<UsuarioModels>
    {
        public void Configure(EntityTypeBuilder<UsuarioModels> builder)
        {
            builder.HasKey(x => x.IdUsuario);
            builder.Property(x => x.IdUsuario)
                .HasColumnName("Id");

            builder.Property(x => x.Nombre)
                .HasColumnType("varchar(50)");
            builder.Property(x => x.Correo)
                .HasColumnType("varchar(MAX)");
            builder.Property(x => x.Password)
                .HasColumnType("varchar(MAX)");
            //builder.Property(x => x.FechaCreacion)
            //    .HasColumnType("DateTime");
        }
    }
}
