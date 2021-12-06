using Firebase.Auth;
using Firebase.Storage;
using BlogC.Data.Interfaz;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace BlogC.Data.Repository
{
    //Implementamos Interfaz de tipo clase
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //Inyectamos
        private readonly NoticiasContext _context;
        private readonly DbSet<T> dbSet;
        public GenericRepository(NoticiasContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
        
        //Api Key de Firebase
        private readonly string ApiKey = "AIzaSyDmTwaJUqDzJb2_a_WOhbrsszN_XJEGmzQ";
        private readonly string Bucket = "contenedornetcoreimages.appspot.com";
        //Correo con el cual se creo storage de Firebase
        private readonly string AuthEmail = "TuCorreoDondeRegistrasFirebase";
        private readonly string AuthPassword = "TuContraseña";

        public StreamContent ConvertBase64ToStream(string image)
        {
            byte[] imageStringToBase64 = Convert.FromBase64String(image);
            StreamContent streamContent = new(new MemoryStream(imageStringToBase64));
            return streamContent;
        }

        public void Crear(T model)
        {
            //_context.Add(model);
            dbSet.Add(model);
            _context.SaveChanges();
        }

        public void Editar(T model)
        {
            dbSet.Update(model);
            _context.SaveChanges();
        }

        public void Eliminar(Guid Id)
        {
            var Tentity = dbSet.Find(Id);
            dbSet.Remove(Tentity);
            _context.SaveChanges();
        }

        public void EliminarPorEstado(Guid Id)
        {
            var Tentity = dbSet.Find(Id);
            if (Tentity!=null)
            {
                var propiedad = Tentity.GetType().GetProperty("Estado");
                if (propiedad != null)
                {
                    throw new Exception("Error");
                }

                propiedad.SetValue(Tentity, false);
                dbSet.Update(Tentity);
                _context.SaveChanges();
            }
        }

        public async Task<IEnumerable<T>> Listar()
        {
            return await dbSet.ToListAsync();
        }

        public async Task<T> ObtenerPorId(Guid Id)
        {
            return await dbSet.FindAsync(Id);
        }

        public async Task<string> UploadImage(Stream stream, string nameImagen)
        {
            string imageFromFirebaseStorage = "";
            FirebaseAuthProvider firebaseConfiguration = new(new FirebaseConfig(ApiKey));

            FirebaseAuthLink authConfiguration = await firebaseConfiguration
                .SignInWithEmailAndPasswordAsync(AuthEmail, AuthPassword);

            CancellationTokenSource cancellationToken = new();

            FirebaseStorageTask storageManager = new FirebaseStorage(Bucket,
                new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(authConfiguration.FirebaseToken),
                    ThrowOnCancel = true
                })
                //.Child(imageDTO.FolderName)
                .Child("Contenedor")
                .Child(nameImagen)
                .PutAsync(stream, cancellationToken.Token);

            try
            {
                imageFromFirebaseStorage = await storageManager;
            }
            catch
            {
                Console.WriteLine("Error");
            }
            return imageFromFirebaseStorage;
        }
    }
}