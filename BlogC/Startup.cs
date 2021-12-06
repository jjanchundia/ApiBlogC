using BlogC.Data;
using BlogC.Data.Interfaz;
using BlogC.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace BlogC
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Habilitamos Cors para Angular - otra app
            services.AddCors();

            services.AddControllers();

            //Inyeccion de dependencia - PersonaRepository
            services.AddScoped<INoticiasRepository, NoticiasRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();

            //Configuramos Cadena DB
            services.AddDbContext<NoticiasContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Conexion")));

            //Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BlogC", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseCors(o=> {            
                o.WithOrigins("https://blog-nuevos.vercel.app");
                o.WithOrigins("http://localhost:4200");
                o.AllowAnyMethod();
                o.AllowAnyHeader();
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //Para entorno de desarrollo
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlogC v1"));
            }

            //Para entorno publicado
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BlogC v1"));

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
