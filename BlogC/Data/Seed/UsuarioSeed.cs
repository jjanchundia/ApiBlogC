using BlogC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace BlogC.Data.Seed
{
    public static class UsuarioSeed
    {
        public static void SeedUsuario(this ModelBuilder modelBuilder)
        {
            //Si no hay data genera nueva data sobre clase/tabla
            modelBuilder.Entity<UsuarioModels>()
                .HasData(new UsuarioModels
                {
                    IdUsuario = new Guid("05f4f68e-9bb1-4e36-836c-0a9daec8736a"),
                    Nombre = "Texto de Prueba",
                    Correo="correo@correo.com",
                    Password="12345",
                    FechaCreacion = DateTime.Now,
                });
        }
    }
}
