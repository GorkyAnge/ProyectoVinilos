﻿using EjercicioEnClase2.Models;
using System.Security.Cryptography;
using System.Text;

namespace EjercicioEnClase2.Util
{
    public class Utils
    {
        public static List<Producto> ListaProducto = new List<Producto>()
        {

        new Producto()
        {
            Id = 1,
            Nombre = "Pies Descalzos",
            Descripcion = "El mejor Album de Shakira",
            Cantidad = 1
        }
        };
    }
}
