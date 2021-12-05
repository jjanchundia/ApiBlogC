using BlogC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlogC.Data.Seed
{
    public static class NoticiasSeed
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Si no hay data genera nueva data sobre clase/tabla
            modelBuilder.Entity<NoticiasModels>()
                .HasData(new NoticiasModels
                {
                    //Id = new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                    Titulo ="Texto de Prueba",
                    //FechaCreacion=DateTime.Now,
                    //FechaModificacion=DateTime.Now,
                    ////Texto="Texto de Prueba para blog de noticias",
                    //Imagen = "Imagenes/image1.png"
                });
        }
    }
}