﻿using APIProductos.Models;
using Microsoft.EntityFrameworkCore;

namespace APIProductos.Data
{
    public class ApplicationDBContext :DbContext
    {

        public ApplicationDBContext(
            DbContextOptions<ApplicationDBContext> options 
            ) : base( options ) { }
            
        
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(

                new Producto
                {
                    Id =1,
                    Nombre="Producto1",
                    Descripcion="Desc1",
                    Precio=30,
                    Cantidad=13,
                    ImagenUrl= "https://universalmusicstore.com.co/cdn/shop/files/LP5_WithDiscs_1024x1024_ca755de2-f423-4915-b8ba-af7851cf9092_1024x.png?v=1695334334"
                }


                );;

            //modelBuilder.Entity<Usuario>().HasData(

            //    new Usuario
            //    {
            //        IdUsuario = 1,
            //        NombreUsuario = "Gorky Palacios",
            //        Correo = "gorkyange@gmail.com",
            //        Contrasena = "Empanada123",

            //    }


            //    ); ;
        }

    }
}
