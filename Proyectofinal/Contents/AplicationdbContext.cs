using Microsoft.EntityFrameworkCore;
using Proyectofinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proyectofinal.Contents
{
    public class AplicationdbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //HACER UNA CONEXION CON LA BASE DE DATOS CREADA EN XAMPP LLAMADA proyectofin
            options.UseMySQL("server = localhost; database= proyectofin; user=root; password= ");

        }
        //add-migration Example
        //Update-Database
        public DbSet<Usuario> Usuarios { get; set; }

    }
}
