using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlogC.Data.Interfaz
{
    //Solo recibe de tipo clase
    public interface IGenericRepository<T> where T:class
    {
        void Crear(T model);
        void Editar(T model);
        void Eliminar(Guid Id);
        void EliminarPorEstado(Guid Id);
        Task<IEnumerable<T>> Listar();
        Task<T> ObtenerPorId(Guid Id);
        StreamContent ConvertBase64ToStream(string image);
        Task<string> UploadImage(Stream stream, string nameImagen);
    }
}
