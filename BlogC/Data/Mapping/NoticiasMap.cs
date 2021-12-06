using BlogC.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogC.Data.Mapping
{
    public class NoticiasMap : IEntityTypeConfiguration<NoticiasModels>
    {
        public void Configure(EntityTypeBuilder<NoticiasModels> builder)
        {
            //builder.HasKey(x => x.Id);
            //builder.Property(x => x.Id)
            //    .HasColumnName("Id");

            builder.Property(x => x.Titulo)
                .HasColumnType("varchar(50)");
            builder.Property(x => x.Content)
                .HasColumnType("varchar(MAX)");
            builder.Property(x => x.Imagen)
                .HasColumnType("varchar(MAX)");
            builder.Property(x => x.Description)
                .HasColumnType("varchar(MAX)");
            builder.Property(x => x.Url);
            //    .HasColumnType("varchar(MAX)");
            //builder.Property(x => x.FechaCreacion)
            //    .HasColumnType("DateTime");
            //builder.Property(x => x.FechaModificacion)
            //    .HasColumnType("DateTime");
        }
    }
}